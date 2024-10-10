using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class gameStartManager : MonoBehaviour
{
    public InputActionReference triggerLeft;
    public InputActionReference triggerRight;

    void Update()
    {
        float leftTriggerVal = triggerLeft.action.ReadValue<float>();
        float rightTriggerVal = triggerRight.action.ReadValue<float>();

        if(leftTriggerVal > 0.5f && rightTriggerVal > 0.5f){

            SceneManager.LoadScene("Scenes/MainScene");
        }
        
    }
}
