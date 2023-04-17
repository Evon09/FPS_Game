using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour
{
    public void Iniciar (){
        SceneManager.LoadScene("Gameplay");
    }

    public void Sair (){
        Application.Quit();
    }
}
