using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conversionDeMoneda : MonoBehaviour
{
    public string codigoMoneda;
    public float montoAConvertir;
    float resultadoDinero;
    float cotizacionMoneda;
    // Start is called before the first frame update
    void Start()
    {
        if (montoAConvertir < 1000)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = 1235.92f;
        }
        else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 932.15f;
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMoneda = 654.48f;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        resultadoDinero = montoAConvertir / cotizacionMoneda;
        Debug.Log("La cantidad de pesos a " + codigoMoneda + " es de " + resultadoDinero + "$" );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
