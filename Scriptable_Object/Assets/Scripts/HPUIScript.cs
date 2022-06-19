using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPUIScript : MonoBehaviour
{
    public FloatVariable playerHP;
    private float prevplayerHP;

    private void Start()
    {
        prevplayerHP = playerHP.value;
    }

    void Update()
    {
        if(playerHP.value != prevplayerHP)
        {
            print(playerHP.value);
            prevplayerHP = playerHP.value;
        }
    }
}
