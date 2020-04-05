using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderText : MonoBehaviour
{
    public GameObject timeSlider;
    public GameObject text;
    public float sliderValue = 0;
    // Update is called once per frame
    public void ChangeTextValue()
    {
        sliderValue = timeSlider.GetComponent<Slider>().value;
        text.GetComponent<Text>().text = "Minutes: " + sliderValue;


    }
}
