using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasBotoes : MonoBehaviour
{
    [SerializeField] private GameObject InicioPage;
    [SerializeField] private GameObject RoletaPage;
    [SerializeField] private GameObject FimPage;

    public GameObject Roleta;

    public void Comecar()
    {
        InicioPage.SetActive(false);
        RoletaPage.SetActive(true);
    }
    public void Fim()
    {
        RoletaPage.SetActive(false);
        FimPage.SetActive(true);
    }

    public void Reiniciar()
    {
        FimPage.SetActive(false);
        RoletaPage.SetActive(true);
        Roleta.GetComponent<RoletaScript>().Reiniciar();
    }
}
