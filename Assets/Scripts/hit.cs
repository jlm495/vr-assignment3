using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision){

        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "bullet") {
            //Destroy(transform.parent.gameObject);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    
    }

}
