using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaInterface : MonoBehaviour
{
    private int pontos;
    [SerializeField]
    private Text textoPontos;


    public void AddPontos()
    {
        pontos += 1;
        textoPontos.text = pontos.ToString();
    }

    public void ResetPontos()
    {
        this.pontos = 0;
        this.textoPontos.text = this.pontos.ToString();
    }

    public void SalvarPontuacao()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if (this.pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("recorde", this.pontos);
        }
        
    }
}
