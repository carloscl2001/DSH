using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tratamientoImpacto : MonoBehaviour
{
    Image barravida;
    float vidaRestante;
    public void eventoHerida(float valorHerida)
    {
        Debug.Log("Enemigo herido");
        barravida = this.transform.GetChild(0).GetChild(0).GetComponent<Image>();
        vidaRestante = GetComponent<gestorVidas>().vida / GetComponent<gestorVidas>().vidaMaxima;
        barravida.transform.localScale = new Vector3(vidaRestante, 1, 1);
    }

    public void eventoMuerte()
    {
        Debug.Log("Enemigo muerto");
        Destroy(gameObject);
    }


}
