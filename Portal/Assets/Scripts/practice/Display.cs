using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//this class displays show text functions
public class Display : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = "Hello world";
    }

    // Update is called once per frame
    public void ChangeText()
    {
        text.GetComponent<Text>().text = "hello sasa :)";
    }
}
