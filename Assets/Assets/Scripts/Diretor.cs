using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imgGameOver;
    private ControlaInterface pontuacao;
    private ControlaGameOver interfaceGameOver;

    private void Start()
    {
        this.pontuacao = GameObject.FindObjectOfType<ControlaInterface>();
        this.interfaceGameOver = GameObject.FindObjectOfType<ControlaGameOver>();
    }
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imgGameOver.SetActive(true);
        this.pontuacao.SalvarPontuacao();
        this.interfaceGameOver.AtualizarInterfaceGrafica();
    }

    public void ReiniciarJogo()
    {
        
        SceneManager.LoadScene("Cena Principal");
        Time.timeScale = 1;
    }
}
