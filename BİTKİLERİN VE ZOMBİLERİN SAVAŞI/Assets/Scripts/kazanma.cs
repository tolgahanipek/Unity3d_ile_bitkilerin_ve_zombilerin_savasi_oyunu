using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class kazanma : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value -= 0.0025f;
        if (GetComponent<Slider>().value<=0f)
        {
            SceneManager.LoadScene("4.Kazanma");
        }
    }
}
