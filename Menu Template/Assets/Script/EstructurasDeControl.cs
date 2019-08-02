using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeControl : MonoBehaviour
{

    public int vida = 50;
    public string Nombre = "miNombre";

    // Start is called before the first frame update
    void Start()
    {
        /*if(vida > 50)
        {
            //PONER ANIMACION DE JUGADOR SANO
            Debug.Log("El jugador tiene vida mayor a 50");
        }
        else if(vida > 30)
        {
            //PONER ANIMACION DE JUGADOR MEDIO SANO
            Debug.Log("El jugador tiene vida mayor a 30");
        }
        else
        {
            //PONER ANIMACION DE JUGADOR HERIDO
            Debug.Log("El jugador tiene vida menor a 50");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (vida > 50)
        {
            //PONER ANIMACION DE JUGADOR SANO
            Debug.Log("El jugador tiene vida mayor a 50");
        }
        else if (vida > 30)
        {
            //PONER ANIMACION DE JUGADOR MEDIO SANO
            Debug.Log("El jugador tiene vida mayor a 30");
        }
        else
        {
            //PONER ANIMACION DE JUGADOR HERIDO
            Debug.Log("El jugador tiene vida menor a 50");
        }
    }
}
