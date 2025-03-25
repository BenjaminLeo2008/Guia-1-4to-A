using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    public int edadUsuario;
    [SerializeField] float estaturaUsuario;
    [SerializeField] bool usuarioDonante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("mi nombre es " + nombreUsuario );
        Debug.Log("tengo " + edadUsuario + "años" );
        Debug.Log("mido " + estaturaUsuario + "M" );
        Debug.Log("es " + usuarioDonante + " que soy donante");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
