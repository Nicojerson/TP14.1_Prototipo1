using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minecraft : MonoBehaviour
{
    private Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 50 * Time.deltaTime);

        float nuevoY = posicionInicial.y + Mathf.Sin(Time.time * 2) * 0.3f;
        transform.position = new Vector3(posicionInicial.x, nuevoY, posicionInicial.z);
    }
}
