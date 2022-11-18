using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{

    public float movimientoEjex;
    public float movimientoEjey;
    public float movimientoEjez;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movimientoEjex, movimientoEjey, movimientoEjez);
    }
}
