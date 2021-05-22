using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liac_chaser : MonoBehaviour
{
    public GameObject target;
    public GameObject[] spheres;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spheres.Length; i++)
        {
            spheres[i] = (GameObject)Instantiate(Resources.Load("Prefab/Sphere_lilac"));
        }
        InitPos();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    //ターゲット周りに円形に配置
    void InitPos()
    {
        Vector3 target_pos = target.transform.position;
        for(int i = 0; i < spheres.Length; i++)
        {
            spheres[i].transform.position = target_pos + new Vector3(4*Mathf.Sin(2*Mathf.PI*i/spheres.Length), 4 * Mathf.Cos(2 * Mathf.PI * i / spheres.Length), 0);
        }
    }
}
