using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoTemporizador;
    public GameObject emptyGameOver;
    public GameObject emptyWin;

    public void ActivarGameOver(){
        emptyGameOver.gameObject.SetActive(true);
    }
     public void ActivarWin(){
        emptyWin.gameObject.SetActive(true);
    }

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
