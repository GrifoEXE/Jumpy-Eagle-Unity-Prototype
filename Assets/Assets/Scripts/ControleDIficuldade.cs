using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDIficuldade : MonoBehaviour
{
    [SerializeField]
    private float tempoParaDificuldadeMaxima;
    private float tempoPassado;

    private void Update()
    {
        this.tempoPassado = Time.deltaTime;

    }
}
