using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerStatus
{
    public int status1;

    public PlayerStatus(Player player)
    {
        status1 = player.status1;
    }

}
