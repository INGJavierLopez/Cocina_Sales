﻿using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;

public class CambioEscenas : MonoBehaviour
{
    public GameObject toDestroy;
    public GameObject boton;
    public string escena; 
    public void OnPress(Hand hand)
    {
        Debug.Log("SteamVR Button pressed!");
        Destroy(toDestroy);
        SceneManager.LoadScene(escena);
        

    }

}
