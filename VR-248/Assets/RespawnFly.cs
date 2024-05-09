using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFly : MonoBehaviour{
    [SerializeField] MeshRenderer fly;
    [SerializeField] BoxCollider flyCollider;
    [SerializeField] AudioSource flySource;
    [SerializeField] AudioClip flyClip;
    [SerializeField] Canvas flyCanvas;
    void Update(){
        fly.enabled = true;
        flyCollider.enabled = true;
        flySource.loop = true;
        flySource.clip = flyClip;
        flySource.Play();
        flyCanvas.gameObject.SetActive(false);
    }
}
