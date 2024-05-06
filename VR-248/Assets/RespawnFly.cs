using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFly : MonoBehaviour{
    [SerializeField] MeshRenderer fly;
    [SerializeField] BoxCollider flyCollider;
    [SerializeField] AudioSource flySource;
    [SerializeField] AudioClip flyClip;
    [SerializeField] bool spawnFly;
    void Update(){
        if(spawnFly){
            fly.enabled = true;
            flyCollider.enabled = true;
            flySource.clip = flyClip;
            flySource.loop = true;
            flySource.Play();
        }
    }
}
