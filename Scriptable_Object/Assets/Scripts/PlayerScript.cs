using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public FloatVariable playerHP;

    void Start()
    {
        playerHP.value = 5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            playerHP.value = playerHP.value - 1;
            //print(playerHP.value);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            playerHP.value = playerHP.value + 1;
            //print(playerHP.value);
        }
    }
}
