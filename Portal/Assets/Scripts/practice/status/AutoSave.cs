using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave : MonoBehaviour
{
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        player.loadPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        player.savePlayer();
    }
}
