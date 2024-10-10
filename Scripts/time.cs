using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class time: MonoBehaviour{

    public GameObject rightHandReference;
    public GameObject leftHandReference;

    Vector3 last_position = new Vector3(0,0,0);

    void Start(){

        last_position = rightHandReference.transform.position + leftHandReference.transform.position;
    }

    void Update(){

        Vector3 current_position = rightHandReference.transform.position + leftHandReference.transform.position;
        Vector3 diff = current_position - last_position;
        float mag = diff.magnitude;
        Time.timeScale = 200f * mag;//1f * mag;
        last_position = current_position;

    }
}
