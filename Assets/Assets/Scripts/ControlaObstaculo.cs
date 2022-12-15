using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidadeObstaculo = 0.01f;
    [SerializeField]
    private float variacaoPosicaoY;

    private ControlaInterface controlaInterface;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    private void Start()
    {
        this.controlaInterface = GameObject.FindObjectOfType<ControlaInterface>();
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

        if (trigger.CompareTag("Jogador"))
        {
            this.controlaInterface.AddPontos();
        }
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }

}
