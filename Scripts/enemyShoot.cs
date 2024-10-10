using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletTemplate;
    public float shootPower = 100f;
    private float shootTimer = 8f;

    void Update()
    {
        shootTimer -= Time.deltaTime;
              
        if(shootTimer < 0){
            shootTimer = 8f;
            Shoot();

        }
        
    }

    void Shoot(){

        GameObject newBullet = Instantiate(BulletTemplate, transform.position + (transform.forward * 0.6f), transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);

    }
   
}
