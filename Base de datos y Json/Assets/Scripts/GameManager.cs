using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librerías añadidas
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GuardadoJsonEncript tal;
    public Text puntosTXT;
    public Text nombreTXT;
    
    public GameObject rankingGO;
    int puntosDB;


    public void GuardarPuntosDB()
    {
        puntosDB = (int)tal.dinero;
        puntosTXT.text = tal.dinero.ToString();
        rankingGO.GetComponent<RankingManager>().InsertarPuntos(nombreTXT.text, puntosDB);
    }
}
