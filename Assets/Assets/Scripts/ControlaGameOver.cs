using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaGameOver : MonoBehaviour
{
    [SerializeField]
    private Text valorRecorde;

    public void AtualizarInterfaceGrafica(){

        int recorde = PlayerPrefs.GetInt("recorde");
        this.valorRecorde.text = recorde.ToString();
        Debug.Log("recorde");
    }
}
