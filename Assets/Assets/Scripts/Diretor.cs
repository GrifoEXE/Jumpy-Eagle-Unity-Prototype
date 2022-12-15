using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Diretor : MonoBehaviour
{
    [SerializeField]
    private GameObject imgGameOver;
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        imgGameOver.SetActive(true);
    }

    public void ReiniciarJogo()
    {
        
        SceneManager.LoadScene("Cena Principal");
        Time.timeScale = 1;
    }
}
