using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instalacao_Vírus : MonoBehaviour
{
    public static float TempoInstalacao = 0;
    public static float TempoTotal = 100;

    public Image Barra_Progress;
    public GameObject Missao3;

    void Update()
    {
        Barra_Progress.fillAmount += TempoInstalacao / TempoTotal;

        if (Barra_Progress.fillAmount == 1)
        {
            GameController_Tempo.missaoCumprida_part3 = true;
            GameController_Tempo.ComecouMissao3 = false;
        }

        if(GameController_Tempo.ComecouMissao3 == false)
        {
            Missao3.SetActive(false);
        }
        else
        {
            Missao3.SetActive(true);
            TempoInstalacao += 0.0001f * Time.deltaTime;
        }
    }
}
