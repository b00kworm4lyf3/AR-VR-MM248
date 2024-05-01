using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChange : MonoBehaviour
{
    public InputActionReference colorReference = null;
    public MeshRenderer meshRenderer = null;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float value = colorReference.action.ReadValue<float>();
        ChangeColor(value);
    }

    public void ChangeColor(float value)
    {
        meshRenderer.material.color = new Color(value, value, value);
    }
}
