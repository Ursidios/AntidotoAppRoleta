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
        if(ValorDeVitoria == 3)
        {
            TxtFim.text = "PARABÉNS!!! Você vai se tornar um milionário!";
        }
        if(ValorDeVitoria == 2)
        {
            TxtFim.text = "Parabéns! Você ainda não é um milionário, mas está muuuito rico.";
        }
        if(ValorDeVitoria == 1)
        {
            TxtFim.text = "Parabéns! Você ganhou bastante dinheiro, tente novamente para mais.";
        }
        if(ValorDeVitoria == 0)
        {
            TxtFim.text = "Infelizmente você não se tornou um milionário mas não desista :)";
        }
    }
}
