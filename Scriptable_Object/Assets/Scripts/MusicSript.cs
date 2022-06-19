using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSript : MonoBehaviour
{
    public FloatVariable playerHP;
    private float prevplayerHP;
    void Start()
    {
        prevplayerHP = playerHP.value;
    }

    void Update()
    {
        if(playerHP.value <= 3)
        {
            print("Playing Ominous music");
        }
        else if (playerHP.value > prevplayerHP)
        {
            print("Music getting upbeat");
            prevplayerHP = playerHP.value;
        }
        else if(playerHP.value < prevplayerHP)
        {
            print("Music getting downbeat");
            prevplayerHP = playerHP.value;
        }
    }
}
