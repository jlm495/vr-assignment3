using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class nextLevel : MonoBehaviour{
    public GameObject[] enemies;
    private float bulletCount = 0;
    public InputActionReference trigger;
     void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext obj){

        bulletCount++;

    }
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("bullet"); // Checks if enemies are available with tag "bullet". Note that you should set this to your enemies in the inspector.
        if(enemies.Length == 1){
            SceneManager.LoadScene("Level2");
        }
        /*if (enemies.Length <= bulletCount){ //enemies.Length == 1 was kinda working
            
            SceneManager.LoadScene("Level2");

        }*/
    }
}