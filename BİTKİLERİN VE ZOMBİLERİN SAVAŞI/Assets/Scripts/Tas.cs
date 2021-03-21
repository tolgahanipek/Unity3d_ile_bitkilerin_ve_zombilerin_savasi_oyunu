using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tas : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Tilki" && collision.gameObject.tag != "Mermi")
        {
            GetComponent<Animator>().SetBool("saldiriVarMi", true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<Animator>().SetBool("saldiriVarMi", false);
    }
}
