using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoTemporizador;

    public void UpdateScore(int puntos)
    {
        textoPuntaje.text = "Puntaje: " + puntos;
    }
    
    public void UpdateTimer()
    {
        if(GameManager.tiempoTranscurrido < 0){
            GameManager.tiempoTranscurrido = 0;
        }
        textoTemporizador.text = "Temporizador: " + GameManager.tiempoTranscurrido;
    }
     void Update()
    {
        UpdateTimer();
    }
}
