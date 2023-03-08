using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBala : MonoBehaviour
{
    public float velocidad;
    public float valorHerida = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 75.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoDistancia = velocidad * Time.deltaTime;
        transform.Translate(Vector3.left * movimientoDistancia);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag ("Enemigo"))
        {
            other.SendMessage("tocado", valorHerida, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
        

    }
}

