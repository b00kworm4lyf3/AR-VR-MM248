using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splat : MonoBehaviour{
    [SerializeField] MeshRenderer fly;
    [SerializeField] BoxCollider flyCollider;
    [SerializeField] AudioSource splatSource;
    [SerializeField] AudioClip splatClip;
    [SerializeField] Canvas flyCanvas;
    [SerializeField] RespawnFly respawnFly;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Swatter")){
            fly.enabled = false;
            flyCollider.enabled = false;
            splatSource.clip = splatClip;
            splatSource.loop = false;
            splatSource.Play();
            flyCanvas.gameObject.SetActive(true);
            respawnFly.enabled = false;
        }
    }
}
