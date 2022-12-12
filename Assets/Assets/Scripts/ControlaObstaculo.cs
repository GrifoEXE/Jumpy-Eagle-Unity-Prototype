using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidadeObstaculo = 0.01f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * 0.01f);
    }
}
