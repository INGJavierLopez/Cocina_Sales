﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarInstrucciones : MonoBehaviour
{
    public GameObject Display;


    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.tag);

                Display.SetActive(false);
        
    }

}
