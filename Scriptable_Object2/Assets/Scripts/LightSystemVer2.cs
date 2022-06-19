using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSystemVer2 : MonoBehaviour
{
    public List<LightConfig> lightConfigs = new List<LightConfig>();
    List<Light> lights = new List<Light>();
    void Start()
    {
        for (int i = 0; i < lightConfigs[0].spawnPoints.Length; i++)
        {
            GameObject currGO = new GameObject(lightConfigs[0].objectName);
            Light currLight = currGO.AddComponent<Light>();


            currLight.color = lightConfigs[0].color;
            currGO.transform.position = lightConfigs[0].spawnPoints[i];
            currLight.intensity = 1;
            lights.Add(currLight);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ChangeColors();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(CycleLights());
            StopCoroutine(CycleLights());
        }
    }

    IEnumerator CycleLights()
    {
        for(int i = 0; i < 50; i++)
        {
            DisplayLights();
            ChangeColors();
            yield return new WaitForSeconds(.2f);
        }
    }

    void DisplayLights()
    {
        foreach (Light l in lights)
        {
            Destroy(l);
        }
        lights.Clear();

        int randomNumber = Random.Range(0, 3);
        for (int i = 0; i < lightConfigs[randomNumber].spawnPoints.Length; i++)
        {
            GameObject currGO = new GameObject(lightConfigs[randomNumber].objectName);
            Light currLight = currGO.AddComponent<Light>();


            currLight.color = lightConfigs[randomNumber].color;
            currGO.transform.position = lightConfigs[randomNumber].spawnPoints[i];
            currLight.intensity = 1;
            lights.Add(currLight);
        }
    }

    void ChangeColors()
    {
        foreach (Light l in lights)
        {
            l.color = Random.ColorHSV();
        }
    }
}
