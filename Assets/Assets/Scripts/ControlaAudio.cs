using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaAudio : MonoBehaviour
{

    private AudioSource audioSource;
    public static AudioSource instancia;

    // Aware runs before start is
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        instancia = audioSource;
    }
}
