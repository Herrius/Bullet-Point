using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullets : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
            {
                Destroy(gameObject);
            }
        if (collision.gameObject.CompareTag("Enemy"))
            {
                puntaje.SumarPuntos(cantidadPuntos);
                Destroy(gameObject);
            }
    }
}
