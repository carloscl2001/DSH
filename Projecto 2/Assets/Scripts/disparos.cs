using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class disparos : MonoBehaviour
{

    float proximoDisparo = 0.0f;
    float tiempoDisparo = 0.3f;
    public GameObject bala;

    Transform salida;

    // Start is called before the first frame update
    void Start()
    {
        salida = GameObject.FindGameObjectWithTag("Pistola").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= proximoDisparo && Input.GetMouseButtonDown(0)){
            proximoDisparo = Time.time + tiempoDisparo;
            GameObject nuevabala = Instantiate(bala, salida.position, salida.rotation);
        }
    }
}