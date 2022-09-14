using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Velocidad = 20;
    public float velGiro = 20;
    private float girar;
    private float avanza;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        avanza = Input.GetAxis("Vertical");
        gira = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*Velocidad);
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
