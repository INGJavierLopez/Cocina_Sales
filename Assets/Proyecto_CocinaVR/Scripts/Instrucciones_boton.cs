﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrucciones_boton : MonoBehaviour
{
    public GameObject Display;
    public GameObject Display2;
    public float tiempoMaximo;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Untagged"))
        {
            Invoke("Desactivar", tiempoMaximo);
        }
    }

    public void Desactivar()
    {
        Display.SetActive(true);
        Display.SetActive(true);
    }
}
