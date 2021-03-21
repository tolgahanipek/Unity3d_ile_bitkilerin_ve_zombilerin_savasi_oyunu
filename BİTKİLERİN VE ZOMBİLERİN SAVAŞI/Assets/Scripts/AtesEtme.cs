﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
    public GameObject mermi,mermininCikisNoktasi;
    private GameObject mermiParent;
    private Animator objeninAnimator;
    private SaldiranObjeyiYolaKoy SaldiriYolu;
    private void  Start()
    {
        objeninAnimator=GetComponent<Animator>();
        mermiParent = GameObject.Find("Mermiler");
        if (!mermiParent)
        {
            mermiParent = new GameObject("Mermiler");
        }
        SaldiranObjeninYolunuBelirle();
    }
    private void Update()
    {
        if (SaldiranObjeYolaGirdiMi())
        {

            objeninAnimator.SetBool("saldiriVarMi", true);
        }
        else
        {
            objeninAnimator.SetBool("saldiriVarMi", false);
        }
    }
    private void AtesEt()
    {
        GameObject yeniMermi = Instantiate(mermi) as GameObject;
        yeniMermi.transform.position = mermininCikisNoktasi.transform.position;
        yeniMermi.transform.parent = mermiParent.transform;
    }
    bool SaldiranObjeYolaGirdiMi()
    {
        if (SaldiriYolu.transform.childCount <= 0)
        {
            return false;
        }


        foreach (Transform saldiranObje in SaldiriYolu.transform)
        {
            if (saldiranObje.transform.position.x > transform.position.x)
            {
                return true;
            }
        }

        return false;
    }
    void SaldiranObjeninYolunuBelirle()
    {
        SaldiranObjeyiYolaKoy[] oyundakiSaldiranObjelerinYollari = GameObject.FindObjectsOfType<SaldiranObjeyiYolaKoy>();

        foreach (SaldiranObjeyiYolaKoy SaldiranObjeninCiktigiYer in oyundakiSaldiranObjelerinYollari)
        {
            if (SaldiranObjeninCiktigiYer.transform.position.y == transform.position.y)
            {
                SaldiriYolu = SaldiranObjeninCiktigiYer;
                return;
            }
        }
    }

}
