using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObj : MonoBehaviour{
    Vector3 startPosition;
    Quaternion startRotation;
    // Start is called before the first frame update
    void Start(){
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Respawn")){
            transform.position = startPosition;
            transform.rotation = startRotation;
        }
    }
}
