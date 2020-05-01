using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public int status1;

    public void savePlayer()
    {
        SaveSystem.SavePlayerStatus(this);
    }

    public void loadPlayer()
    {
        PlayerStatus status = SaveSystem.LoadPlayerStatus();
        status1 = status.status1;
    }
}
