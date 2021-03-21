using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzikKontrolu : MonoBehaviour
{
    static muzikKontrolu muzikOynaticisi;
    private void Awake()
    {
        Debug.Log("Awake çalıştı.");
        if (muzikOynaticisi != null)
        {
            Destroy(gameObject);
        }
        else
        {
            muzikOynaticisi = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    public void SesiAyarla(float sesDegeri)
    {
        GetComponent<AudioSource>().volume = sesDegeri;

    }
    void Start()
    {
        Debug.Log("Start çalıştı");
    }
      
        
    

  
    void Update()
    {
        
    }
}
