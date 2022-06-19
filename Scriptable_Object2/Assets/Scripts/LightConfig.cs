using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LightData", menuName = "Lighting/LightConfig", order = 1)]
public class LightConfig : ScriptableObject
{
    public string objectName;
    public bool colorIsRandom = false;
    public Color color = Color.green;
    public Vector3[] spawnPoints;
}
