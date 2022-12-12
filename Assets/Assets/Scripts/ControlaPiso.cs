using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPiso : MonoBehaviour
{
    [SerializeField]
    private float velocidade;

    private Vector3 posicaoInicial;

    private float tamanhoChao;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        this.tamanhoChao = this.GetComponent<BoxCollider2D>().size.x;
    }

    private void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoChao);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
