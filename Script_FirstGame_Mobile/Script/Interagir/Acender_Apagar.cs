using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Acender_Apagar : MonoBehaviour
{
    public GameObject Buttom;

    public TextMeshProUGUI Texto;
    public GameObject[] Luzes;
    public bool ApagarLuz;
    public bool LuzesApagada;

    private void Start()
    {
        LuzesApagada = true;
    }

   public void AcenderLuz()
    {
        if (LuzesApagada == false)
        {
            LuzesApagada = true;
        }
        else
        {
            LuzesApagada = false;
        }
        for (int i = 0; i < Luzes.Length; i++)
        {
            Luzes[i].GetComponent<Light>().gameObject.SetActive(LuzesApagada);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Buttom.SetActive(true);
            ApagarLuz = true;
            Texto.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Buttom.SetActive(false);
            ApagarLuz = false;
            Texto.gameObject.SetActive(false);
        }
    }
}
