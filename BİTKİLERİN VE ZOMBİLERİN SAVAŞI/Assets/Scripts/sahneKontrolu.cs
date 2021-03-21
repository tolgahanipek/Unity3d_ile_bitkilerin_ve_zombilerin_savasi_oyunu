using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahneKontrolu : MonoBehaviour
{
    public float sonrakiSahneninYuklemeSuresi;
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "0.Menüdenöncekisahne")
        {
            Invoke("SonrakiSahne", sonrakiSahneninYuklemeSuresi);
        }
      
    }
   public void SonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void OyundanCikis()
    {
        Debug.Log("oyundan çıkma gerçekleşti");
        Application.Quit();
    }
    public void IsimleSahneCagirma(string sahneIsmi)
    {
        SceneManager.LoadScene(sahneIsmi);

    }
    public void IndexleSahneCagirma(int sahneIndexi)
    {
        SceneManager.LoadScene(sahneIndexi);

    }


}
