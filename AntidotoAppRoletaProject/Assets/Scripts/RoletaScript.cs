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
    public bool RoletaLiberada;
    public bool Finalizar;

    [SerializeField] private int Venceu;
    public Text TxtPontuacao;
    public Text[] TxtFatias;
    public GameObject[] ColisorFatias;
    public int[] ValoresFatias;

    public GameObject TextoFim;
    public GameObject RotasBotoes;
    public GameObject TelaPontosGanhos;
    public Text TxtPontosGanhos;
    public GameObject ObjInfo;
    public GameObject BotaoFinalizar;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        RoletaLiberada = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Ajuste de UX para facilitar o entendimento do fluxo de jogo
        //ativando o botão finalizar ao inicio para obrigar o jogador a clicar na roleta
        if(Pontos == 0)
        {
            ObjInfo.SetActive(true);
            BotaoFinalizar.SetActive(false);
        }
        else
        {
            ObjInfo.SetActive(false);
            BotaoFinalizar.SetActive(true);

        }

        // Atualiza os valores de pontuação do jogador
        TxtPontuacao.text = "Pontuação: " + Pontos;

        // Captura a Velocidade angular da roleta para dectar se ela parou
        VelocidadeAngularAtual = gameObject.GetComponent<Rigidbody2D>().angularVelocity;

        if(VelocidadeAngularAtual == 0 && RoletaRodando)
        {
            Pontos += PontosGanhos; // Soma a pontuação ganha com o total
            TelaPontosGanhos.SetActive(true); // Faz aparecer a tela informativa
            TxtPontosGanhos.text = PontosGanhos.ToString(); // Informa a quantidade ganha
            RoletaLiberada = false; // Faz a liberação da roleta
            RoletaRodando = false; // E informa que ela nao esta rodando mais   
            BotaoFinalizar.GetComponent<Image>().color = new Color(1, 1, 1, 1f); //Define a transparencia do botão de volta para o padrão após a roleta rodar    
        }

        // esta é a roleta de valores de cada fatia, que enquando não esta rodando recebe valores aleatorios
        if(!RoletaRodando && RoletaLiberada)
        {
            for(int i = 0; i < ValoresFatias.Length; i++)
            {
                ValoresFatias[i] = Random.Range(1, 14);
            }
        }

        // Atualiza em tela os valores das fatias 
        for(int i = 0; i < TxtFatias.Length; i++)
        {
            TxtFatias[i].text = ValoresFatias[i].ToString();
            ColisorFatias[i].GetComponent<ArmazemValorFatia>().ValorFatia = ValoresFatias[i];
        }

        // Modelos de vitoria e derrota
        if(Pontos > 21)
        {
            Finalizar = true;
        }
        
        if(Finalizar && RoletaLiberada)
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

            // Ao finalizar é passado para o TextoFimScript o tipo de vitoria ou derrota.
            TextoFim.GetComponent<TextoFimScript>().ValorDeVitoria = Venceu;
            // Chama o metodo Fim nas Rostas dos Botoes
            RotasBotoes.GetComponent<RotasBotoes>().Fim();
        }
    }

    // Metodo de Rolagem da Roleta
    public void RolarRoleta()
    {
        //Verificador de Rolagem
        if(!RoletaRodando)
        {
            Forca = Random.Range(2000, 7000); //Define um Valor aleatorio de Força à roleta
            rb.angularVelocity = -Forca; //Define uma força à roleta usando RigidBody
            RoletaRodando = true; // E define que a roleta esta Rodando
            BotaoFinalizar.GetComponent<Image>().color = new Color(1, 1, 1, 0.1f); //Para melhoria de UX o botão fica com menos opacidade enquanto a roleta roda
        }

    }

    // metodo que recebe a quantia pela qual a roleta parou e passa para a variavel PontosGanhos
    public void RoletaParou(int Quantidade)
    {
        PontosGanhos = Quantidade;
    }

    // Metodo que Finaliza as jogadas apenas se a roleta NÃO estiver Rodando
    public void BtnFinalizar()
    {
        if(!RoletaRodando && Pontos != 0)
        {
            Finalizar = true;
        }
    }

    // Metodo que reseta as variaveis necessárias para que o jogo possa acontecer novamente
    public void Reiniciar()
    {
        Finalizar = false;
        Pontos = 0;
    }
}
