using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderDsp : MonoBehaviour
{

    public GameObject slider;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        slider.GetComponent<Slider>().value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = slider.GetComponent<Slider>().value.ToString();
    }
}
