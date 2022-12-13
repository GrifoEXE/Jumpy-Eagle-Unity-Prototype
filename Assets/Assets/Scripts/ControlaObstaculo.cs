using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidadeObstaculo = 0.01f;
    [SerializeField]
    private float variacaoPosicaoY;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidadeObstaculo * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Destroy"))
        {
            this.Destruir();
        }
    }

    private void Destruir()
    {
        Debug.Log("Hit");
        Destroy(this.gameObject);
    }
}
