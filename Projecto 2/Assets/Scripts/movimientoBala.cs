using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBala : MonoBehaviour
{
    public float velocidad = 5.0f;
    public float valorHerida = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoDistancia = velocidad * Time.deltaTime;
        transform.Translate(Vector3.up * movimientoDistancia);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag ("Enemigo"))
        {
            other.SendMessage("tocado", valorHerida, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
        

    }
}
