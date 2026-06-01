using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{ 
    UIManager uiManagerScript;
    int contador = 0;
   
    void Start()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
    }
        void OnTriggerEnter(Collider other)
    {
    if(other.CompareTag("Coleccionable")){
        Destroy(other.gameObject);
        contador = contador + 1;
        uiManagerScript.UpdateScore(contador);
    }
    }
}
