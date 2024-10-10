using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    private float move_speed = 100f;
    private GameObject playerTarget;
    

    // Update is called once per frame
    void Update()
    {
        if(playerTarget != null){

            transform.LookAt(playerTarget.transform.position);
            transform.position += transform.forward * move_speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "detectBox"){

            playerTarget = other.gameObject;
        }
    }
}
