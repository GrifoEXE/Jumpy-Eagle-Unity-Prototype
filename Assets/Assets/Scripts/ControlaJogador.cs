using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]
    private float forcaPulo;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Pular();
        }
    }

    private void Pular()
    {
        this.rb.velocity = Vector2.zero;
        this.rb.AddForce(Vector2.up * this.forcaPulo, ForceMode2D.Impulse);
    }
}
