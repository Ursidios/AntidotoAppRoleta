using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoFimScript : MonoBehaviour
{
    public int ValorDeVitoria;
    public Text TxtFim;

    void Start()
    {
        TxtFim = gameObject.GetComponent<Text>();
    }
    void Update()
    {
        // Seletor de possibilidade de vitória
        // Recebe o valor de vitoria do RoletaScript e compara para premiar de forma condizente
        if(ValorDeVitoria == 3)
        {
            TxtFim.text = "PARABÉNS!!! Você vai se tornar um milionário!";
        }
        else if(ValorDeVitoria == 2)
        {
            TxtFim.text = "Parabéns! Você ainda não é um milionário, mas está muuuito rico.";
        }
        else if(ValorDeVitoria == 1)
        {
            TxtFim.text = "Parabéns! Você ganhou bastante dinheiro, tente novamente para mais.";
        }
        else if(ValorDeVitoria == 0)
        {
            TxtFim.text = "Infelizmente você não se tornou um milionário mas não desista :)";
        }
    }
}
