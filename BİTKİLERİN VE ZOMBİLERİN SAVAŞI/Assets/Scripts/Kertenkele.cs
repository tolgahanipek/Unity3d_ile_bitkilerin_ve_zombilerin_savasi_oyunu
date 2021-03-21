﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Saldiranlar))]
public class Kertenkele : MonoBehaviour
{

    private Animator kertenkeleAnimator;
    private Saldiranlar saldiranObje;
    // Use this for initialization
    void Start()
    {
        kertenkeleAnimator = GetComponent<Animator>();
        saldiranObje = GetComponent<Saldiranlar>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject kertenkeleninEtkilesimeGirdigiObje = collision.gameObject;

        if (!kertenkeleninEtkilesimeGirdigiObje.GetComponent<Savunanlar>())
        {
            return;
        }
        else
        {
            kertenkeleAnimator.SetBool("saldiriVarMi", true);
            saldiranObje.HedefiBelirle(kertenkeleninEtkilesimeGirdigiObje);
        }
    }
}
