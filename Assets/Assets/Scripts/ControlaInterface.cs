using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaInterface : MonoBehaviour
{
    public int Pontos { get; private set; }
    [SerializeField]
    private Text textoPontos;


    public void AddPontos()
    {
        Pontos += 1;
        textoPontos.text = Pontos.ToString();
    }

    public void ResetPontos()
    {
        this.Pontos = 0;
        this.textoPontos.text = this.Pontos.ToString();
    }

    public void SalvarPontuacao()
    {
        int recordeAtual = PlayerPrefs.GetInt("recorde");
        if (this.Pontos > recordeAtual)
        {
            PlayerPrefs.SetInt("recorde", this.Pontos);
        }
        
    }
}
