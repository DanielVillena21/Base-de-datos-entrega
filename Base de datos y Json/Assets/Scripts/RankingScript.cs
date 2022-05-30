using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librería UI Unity
using UnityEngine.UI;

public class RankingScript : MonoBehaviour
{
    //Variables para acceder a los objetos Text
    public Text Posicion, Nombre, Dinero;

    //Método para poner los puntos en la UI
    public void PonerPuntos(string pos, string nombre, string dinero)
    {
        Posicion.text = pos;
        Nombre.text = nombre;
        Dinero.text = dinero;
 
   }
    
}
