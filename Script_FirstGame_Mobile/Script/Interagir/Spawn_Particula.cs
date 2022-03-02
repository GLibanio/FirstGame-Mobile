using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Particula : MonoBehaviour
{
    public GameObject Buttom;

    public GameObject Hud;
    public GameObject Particula;

    bool Aberto;
    bool Clicar;

    public void Interagir()
    {
        if (!Aberto)
        {
            Particula.SetActive(true);
            Aberto = true;
        }
        else
        {
            Particula.SetActive(false);
            Aberto = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Buttom.SetActive(true);
        Hud.SetActive(true);
        Clicar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Buttom.SetActive(false);
        Hud.SetActive(false);
        Clicar = false;
    }
}
