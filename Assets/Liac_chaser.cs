using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liac_chaser : MonoBehaviour
{
    public GameObject target;
    public GameObject[] spheres;
    private int liac_num;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spheres.Length; i++)
        {
            spheres[i] = (GameObject)Instantiate(Resources.Load("Prefab/Sphere_lilac"));
        }
        InitPos();
        liac_num =0;
        InvokeRepeating("Liac", 1, speed);
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

    void Liac()
    {
        Spheres_On_Off(spheres[liac_num]);
        liac_num++;
        
        if (liac_num == spheres.Length)
        {
            liac_num = 0;
        }
    }

    void Spheres_On_Off(GameObject obj)
    {
        if (obj.activeSelf)
        {
            obj.SetActive(false);
            StartCoroutine(On_Sphere(obj));
        }
        else
        {
            obj.SetActive(true);
        }
    }

    IEnumerator On_Sphere(GameObject obj)
    {
        yield return new WaitForSeconds(speed);
        obj.SetActive(true);
    }
}
