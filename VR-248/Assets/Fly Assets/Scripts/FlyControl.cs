using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Klak.Motion;

public class FlyControl : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI text;
    public BrownianMotion brownMo;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        brownMo.frequency = slider.value;
    }

    // public void OnSliderChange(float value)
    // {
    //     text.text = value.ToString();
    //     brownMo.frequency = value;
    // }
}
