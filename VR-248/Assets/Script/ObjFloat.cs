using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFloat : MonoBehaviour
{
    [SerializeField] float floatStrength;
    Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        rb.AddForce(0, floatStrength, 0);
    }
}
