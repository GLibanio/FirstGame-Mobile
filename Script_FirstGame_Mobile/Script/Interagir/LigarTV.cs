using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarTV : MonoBehaviour
{
    public GameObject Buttom;

    public GameObject Instrucao;
    public GameObject CanalTv;
    bool TV_Ligada;

    public void Ligar_TV()
    {
        if (!TV_Ligada)
        {
            CanalTv.SetActive(true);
            TV_Ligada = true;
        }
        else
        {
            CanalTv.SetActive(false);
            TV_Ligada = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Buttom.SetActive(true);
            Instrucao.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Buttom.SetActive(false);
            Instrucao.SetActive(false);
        }
    }
}
