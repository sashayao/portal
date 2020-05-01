using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showStat : MonoBehaviour
{
    public GameObject statusText;


    public void showGameStat(Player player)
    {
        statusText.GetComponent<Text>().text = SaveSystem.LoadPlayerStatus().status1.ToString();
    }
}
