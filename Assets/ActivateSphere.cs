using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSphere : MonoBehaviour
{
    GameObject[] spheres;
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("Sphere");
    }

    public void OnClicked()
    {
        if (spheres[0].activeSelf)
        {
            for(int i = 0; i < spheres.Length; i++)
            {
                spheres[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < spheres.Length; i++)
            {
                spheres[i].SetActive(true);
            }
        }
    }
}
