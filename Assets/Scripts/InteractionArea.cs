using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{   
    int contador = 0;
    void OnTriggerEnter(Collider other)
    {

    if(other.CompareTag("Coleccionable")){
        Destroy(other.gameObject);
        contador = contador + 1;
        Debug.Log("El contador es: " + contador);
    }
    }
}
