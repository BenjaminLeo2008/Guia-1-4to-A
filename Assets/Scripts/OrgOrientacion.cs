using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgOrientacion : MonoBehaviour
{
    public string nombreAlumno;
    public int año;
    public char orientacion;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("Error: Nombre y apellido incompleto");
            return;
        }
        else if (año >= 6)
        {
            Debug.Log("Error: El año seleccionado no existe");
            return;
        }
        if (orientacion != 'H' || orientacion != 'M' || orientacion != 'T' || orientacion != 'G' || orientacion != 'D')
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }
        if (año <= 3 && año >= 5)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }
        Debug.Log("Muchas gracias " + nombreAlumno + "!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
