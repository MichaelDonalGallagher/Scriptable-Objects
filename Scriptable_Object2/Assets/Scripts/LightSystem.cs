using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSystem : MonoBehaviour
{
    public LightConfig lightConfig;
    List<Light> lights = new List<Light>();
    void Start()
    {
        for(int i = 0; i < lightConfig.spawnPoints.Length; i++)
        {
            GameObject currGO = new GameObject(lightConfig.objectName);
            Light currLight = currGO.AddComponent<Light>();


            currLight.color = lightConfig.color;
            currGO.transform.position = lightConfig.spawnPoints[i];
            currLight.intensity = 0;
            lights.Add(currLight);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            foreach(Light l in lights)
            {
                if (l.intensity == 0)
                    l.intensity = 1;
                else
                    l.intensity = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            foreach(Light l in lights)
            {
                l.color = Random.ColorHSV();
            }
        }
    }
}
