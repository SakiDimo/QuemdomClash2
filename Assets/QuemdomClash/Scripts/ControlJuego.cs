using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ControlJuego : MonoBehaviour
{
    public void OnJugar()
    {
        Debug.Log("Ir a Jugar");
        MMSceneLoadingManager.LoadScene("Nvl 1");
    }
    public void OnInstrucciones()
    {
        Debug.Log("Ir a instrucciones");
        MMSceneLoadingManager.LoadScene("instrucciones");
    }
    public void OnCreditos()
    {
        Debug.Log("Ir a Creditos");
        MMSceneLoadingManager.LoadScene("Creditos");
    }
    public void OnVolver()
    {
        Debug.Log("Volver al menu");
        MMSceneLoadingManager.LoadScene("home");
    }
}
