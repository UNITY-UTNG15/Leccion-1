/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al player a moverse sobre hacia adelante,
* hacia atras, hacia la izquierda y hacia la derecha.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables para realizar la funcionalidad de movimiento del carrito
    public float Velocidad = 20;

    public float velGiro = 20;

    private float gira;

    private float avanza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // variables para realizar el movimiento con las teclas del teclado.
        avanza = Input.GetAxis("Vertical");
        gira = Input.GetAxis("Horizontal");
        // Movimiento del carrito
        transform.Translate(Vector3.forward*Time.deltaTime*Velocidad*avanza);
        // Rotacion del carrito
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
