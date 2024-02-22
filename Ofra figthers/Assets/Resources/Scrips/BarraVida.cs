using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraVida : MonoBehaviour
{
    public Image barraDeVida;
    public float vidaActual;
    public float vidaMaxima;
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
    }
}
