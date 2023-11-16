using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostradorPontosGanhosScript : MonoBehaviour
{
    public GameObject Roleta;

    // Método que tira da tela o pop-up informativo de quantidade de ponstos ganhos
//por meio de um evento que acontece ao fim de sua animação
    public void RodarNovamente()
    {
        gameObject.SetActive(false);
        Roleta.GetComponent<RoletaScript>().RoletaLiberada = true;
    }
}
