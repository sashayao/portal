using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class incStat: MonoBehaviour
{
    public Player player;
    public GameObject text;
    // Start is called before the first frame update
    public void increaseStatus()
    {
        player.status1 += 1;
        text.GetComponent<Text>().text = player.status1.ToString();
           
    }

}
