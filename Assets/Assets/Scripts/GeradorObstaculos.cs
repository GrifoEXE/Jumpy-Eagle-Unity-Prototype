using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarFacil;
    [SerializeField]
    private float tempoParaGerarDificil;
    [SerializeField]
    private GameObject obstaculosPrefab;
    private float cronometro;

    private ControleDificuldade dificuldade;
    private void Start()
    {
        dificuldade = GameObject.FindObjectOfType<ControleDificuldade>();
    }

    private void Awake()
    {
        this.cronometro = this.tempoParaGerarFacil;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.obstaculosPrefab, 
                this.transform.position, Quaternion.identity);
            this.cronometro = Mathf.Lerp(
                this.tempoParaGerarFacil, 
                this.tempoParaGerarDificil, 
                dificuldade.Dificuldade);
        }
    }
}
