using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public void ChangeScene()
    {
        int num = SceneManager.GetActiveScene().buildIndex;
        int total_scene_num = 2;

        if (num == total_scene_num)
        {
            num = 0;
            SceneManager.LoadScene(num);
        }
        else
        {
            num++;
            SceneManager.LoadScene(num);
        }
    }
}
