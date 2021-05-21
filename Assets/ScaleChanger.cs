using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleChanger : MonoBehaviour
{
    public GameObject obj;
    public GameObject[] objs;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void objScaler()
    {
        obj.transform.localScale = new Vector3(slider.value, slider.value, 1);
    }
    public void objsScaler()
    {
        for(int i = 0; i < objs.Length; i++)
        {
            objs[i].transform.localScale = new Vector3(slider.value, slider.value, 1);
        }
    }
}
