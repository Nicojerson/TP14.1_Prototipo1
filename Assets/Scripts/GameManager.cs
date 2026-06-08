using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    UIManager uiManagerScript;
    public static float tiempoTranscurrido = 60f; 

    void Awake(){
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
        Time.timeScale = 1;
        tiempoTranscurrido = 60f; 

       }
    

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido -= Time.deltaTime;
        if(tiempoTranscurrido < 0){
            Time.timeScale = 0;
            uiManagerScript.ActivarGameOver();
            }

            if (Time.timeScale == 0){
            if(Input.GetKeyDown(KeyCode.R)){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            }
        }
    

}
