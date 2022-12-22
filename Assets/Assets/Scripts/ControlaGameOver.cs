using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaGameOver : MonoBehaviour
{
    [SerializeField]
    private Text valorRecorde;
    private int recorde;

    [SerializeField]
    private Image posicaoMedalha;
    [SerializeField]
    private Sprite medalhaOuro;
    [SerializeField]
    private Sprite medalhaPrata;
    [SerializeField]
    private Sprite medalhaBronze;


    private ControlaInterface pontuacao;
    private void Start()
    {
        pontuacao = GameObject.FindObjectOfType<ControlaInterface>();
    }

    public void AtualizarInterfaceGrafica(){

        this.recorde = PlayerPrefs.GetInt("recorde");
        this.valorRecorde.text = recorde.ToString();

        VerificarCorMedalha();
    }

    private void VerificarCorMedalha()
    {
        if(this.pontuacao.Pontos > this.recorde - 2)
        {
            this.posicaoMedalha.sprite = this.medalhaOuro;
        }
        else if(this.pontuacao.Pontos > recorde / 2)
        {
            this.posicaoMedalha.sprite = this.medalhaPrata;
        }
        else
        {
            this.posicaoMedalha.sprite = this.medalhaBronze;
        }
    }
}
