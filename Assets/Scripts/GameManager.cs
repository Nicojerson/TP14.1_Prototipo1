using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    UIManager uiManagerScript;
    public static float tiempoTranscurrido = 60f; 

    // Start is called before the first frame update
    void Start()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido -= Time.deltaTime;
    }
}
