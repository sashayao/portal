using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 5;
    public GameObject timer;

    // Update is called once per frame
    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
            int displayTime = (int)time;
            timer.GetComponent<Text>().text = displayTime.ToString();
        }
        
        if (time <= 0)
        {
            timer.GetComponent<Text>().text = "doneeee!!!";
        }
    }
}
