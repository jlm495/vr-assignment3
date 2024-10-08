using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletTemplate;
    public float shootPower = 500f;
    public InputActionReference trigger;
    void Start()
    {
        trigger.action.performed += Shoot;
    }

    void Shoot(InputAction.CallbackContext obj){

        GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);

    }
   
}
