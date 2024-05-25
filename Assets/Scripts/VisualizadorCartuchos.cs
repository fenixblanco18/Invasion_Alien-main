using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VisualizadorCartuchos : MonoBehaviour
{
    Arma arma;
    public TextMeshProUGUI textoNumeroCartuchos;
    void Start()
    {
        arma = GameObject.Find("Main_Character").GetComponent<Arma>();
    }

    // Update is called once per frame
    void Update()
    {
        textoNumeroCartuchos.text = arma.municion.ToString();
    }
}
