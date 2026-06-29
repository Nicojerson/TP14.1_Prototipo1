using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoPuntaje;
    public TextMeshProUGUI textoTemporizador;
    public TextMeshProUGUI textoTitulo;
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
    
     public void UpdateTitle()
    {
        if(GameManager.tiempoTranscurrido < 55){
        textoTitulo.text = (" ");     
        }
    }

    public void UpdateTimer()
    {
        if(GameManager.tiempoTranscurrido < 0){
            GameManager.tiempoTranscurrido = 0;
        }
        textoTemporizador.text = "Tiempo: " + Mathf.Ceil(GameManager.tiempoTranscurrido);
    }
    void Start()
    {
        textoTitulo.text = ("Recolectá los 4 microscopios del laboratorio para ganar");     
    }


     void Update()
    {
        UpdateTimer();
        UpdateTitle();
    }
    
}
