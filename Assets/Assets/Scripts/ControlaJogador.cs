using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    private Rigidbody2D rb;
    private Diretor diretor;

    [SerializeField]
    private AudioClip somPulo;

    [SerializeField]
    private AudioClip somHit;

    [SerializeField]
    private float forcaPulo;

    private bool impulsionar;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            impulsionar = true;
        }
    }

    private void FixedUpdate()
    {
        if (this.impulsionar) {
            this.Pular();
        }
    }

    private void Pular()
    {
        ControlaAudio.instancia.PlayOneShot(somPulo);
        this.rb.velocity = Vector2.zero;
        this.rb.AddForce(Vector2.up * this.forcaPulo, ForceMode2D.Impulse);
        impulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        ControlaAudio.instancia.PlayOneShot(somHit);
        this.rb.simulated = false;
        Debug.Log("hit");
        this.diretor.FinalizarJogo();
    }
}
