using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    string nombre = "mi nombre";
    int edad = 23;
    float temperatura = 20.2f;


    // Start is called before the first frame update
    void Start()
    {
        imprimirNombre();
        imprimirEdad();
        imprimirTemperatura();

    }

    // Update is called once per frame
    void Update()
    {
        imprimirNombre();
    }

    void imprimirNombre()
    {
        Debug.Log("bla");
    }



    void imprimirEdad()
    {
        Debug.Log(edad);
    }



    void imprimirTemperatura()
    {
        Debug.Log(temperatura);
    }

}
