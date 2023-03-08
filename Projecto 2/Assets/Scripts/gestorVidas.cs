using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gestorVidas : MonoBehaviour
{
    public float vida = 5.0f;
    public float vidaMaxima = 5.0f;

    public UnityEvent eventoMuerte;
    public UnityEvent eventoHerida;

    void tocado(float valorHerida)
    {
        vida -= valorHerida;
        eventoHerida.Invoke();
        if (vida <= 0)
        {
            eventoMuerte.Invoke();
        }
    }
}
