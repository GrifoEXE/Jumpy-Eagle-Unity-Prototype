using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDificuldade : MonoBehaviour
{
    [SerializeField]
    private float tempoParaDificuldadeMaxima;
    private float tempoPassado;
    public float Dificuldade { get; private set; }

    private void Update()
    {
        this.tempoPassado += Time.deltaTime;
        this.Dificuldade = tempoPassado / tempoParaDificuldadeMaxima;
        Dificuldade = Mathf.Min(1, this.Dificuldade);
    }
}
