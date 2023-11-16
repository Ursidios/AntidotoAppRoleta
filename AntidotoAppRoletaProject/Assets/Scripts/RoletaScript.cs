using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoletaScript : MonoBehaviour
{
    public float Forca;
    private float VelocidadeAngularAtual;
    private Rigidbody2D rb;

    [SerializeField] private int Pontos;
    [SerializeField] private int PontosGanhos;
    public bool RoletaRodando;
    public bool Finalizar;

    [SerializeField] private int Venceu;
    public Text TxtPontuacao;
    public Text[] TxtFatias;
    public GameObject[] ColisorFatias;
    public int[] ValoresFatias;

    public GameObject TextoFim;
    public GameObject RotasBotoes;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TxtPontuacao.text = "Pontuação: " + Pontos;
        VelocidadeAngularAtual = gameObject.GetComponent<Rigidbody2D>().angularVelocity;

        if(VelocidadeAngularAtual == 0 && RoletaRodando)
        {
            Pontos += PontosGanhos;
            RoletaRodando = false;
        }
        if(!RoletaRodando)
        {
            for(int i = 0; i < ValoresFatias.Length; i++)
            {
                ValoresFatias[i] = Random.Range(1, 14);
            }
        }
        for(int i = 0; i < TxtFatias.Length; i++)
        {
            TxtFatias[i].text = ValoresFatias[i].ToString();
            ColisorFatias[i].GetComponent<ArmazemValorFatia>().ValorFatia = ValoresFatias[i];
        }

        if(Pontos > 21)
        {
            Finalizar = true;
        }

        if(Finalizar)
        {
            if(Pontos == 21)
            {
                Venceu = 3;
            }
            else if(Pontos == 20)
            {
                Venceu = 2;
            }
            else if(Pontos == 19)
            {
                Venceu = 1;
            }
            else
            {
                Venceu = 0;
            }

            TextoFim.GetComponent<TextoFimScript>().ValorDeVitoria = Venceu;
            RotasBotoes.GetComponent<RotasBotoes>().Fim();
        }
    }
    public void RolarRoleta()
    {
        if(!RoletaRodando)
        {
            Forca = Random.Range(2000, 7000);
            rb.angularVelocity = -Forca;
            RoletaRodando = true;
        }

    }

    public void RoletaParou(int Quantidade)
    {
        PontosGanhos = Quantidade;
    }

    public void BtnFinalizar()
    {
        if(!RoletaRodando || Pontos == 0)
        {
            Finalizar = true;
        }
    }

    public void Reiniciar()
    {
        Finalizar = false;
        Pontos = 0;
    }
}
