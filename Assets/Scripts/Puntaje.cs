using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos=0f;
    private TextMeshProUGUI textMesh;

    private void Start(){
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
       // textMesh.text = puntos.ToString("0");
    }
    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
