using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostradorPontosGanhosScript : MonoBehaviour
{
    public GameObject Roleta;
    public void RodarNovamente()
    {
        gameObject.SetActive(false);
        Roleta.GetComponent<RoletaScript>().RoletaLiberada = true;
    }
}
