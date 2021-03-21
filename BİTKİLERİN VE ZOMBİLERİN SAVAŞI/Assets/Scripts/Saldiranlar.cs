using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saldiranlar : MonoBehaviour
{
    // [Range(0f,2f)]
    private float SuAnkiHiz;
    private GameObject mevcutHedef;
    private Animator objeninAnimatoru;

    public float kacSaniyedeBirDogacak;

    void Start()
    {
        // Rigidbody2D objeninRigidbodysi = gameObject.AddComponent<Rigidbody2D>();
        //objeninRigidbodysi.isKinematic = true;
        objeninAnimatoru = GetComponent<Animator>();
    }


    void Update()
    {
        transform.Translate(Vector3.left * SuAnkiHiz * Time.deltaTime);
        if (!mevcutHedef)
        {
            objeninAnimatoru.SetBool("saldiriVarMi", false);
        }
    }

    
    public void SuAnkiHiziAyarla(float hiz)
    {
        SuAnkiHiz = hiz;
    }
    public void ZararVer(float zararMiktari)
    {
        if (mevcutHedef)
        {
            Saglik saglik = mevcutHedef.GetComponent<Saglik>();
            if (saglik)
            {
                saglik.ZararAl(zararMiktari);
            }
        }
    }
    public void HedefiBelirle(GameObject hedefimiz)
    {
        mevcutHedef = hedefimiz;
    }

}
