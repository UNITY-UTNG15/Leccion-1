/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion de Script: Este Script ayuda al movimiento y seguimiento de la camara,
* ya que esta debe de seguir al objeto de tipo carro.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControll : MonoBehaviour
{
    public GameObject carro;
    public Vector3 upCam = new Vector3(0,10,-00);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento del objeto de tipo carro
        transform.position = carro.transform.position + upCam;
    }
}
