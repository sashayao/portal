using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStatus : MonoBehaviour
{
    public static GameObject status;

    public void RevealStatus(){
        status.SetActive(true);
    }
 
}
