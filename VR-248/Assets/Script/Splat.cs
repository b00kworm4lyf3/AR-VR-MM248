using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splat : MonoBehaviour{
    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Fly")){
            Destroy(other.gameObject);
        }
    }
}
