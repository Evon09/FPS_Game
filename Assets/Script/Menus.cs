using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public Canvas pause;
    public Canvas morte;

    private bool isPaused = true;
    private bool morto = false;

     public GameObject objetoParaDesativar;

    private void Start() {
        VoltarJogo();
    }

    void Update() {
       
        if (Input.GetKeyDown(KeyCode.Escape) && morto == false) {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            if(isPaused){
                pause.gameObject.SetActive(true);
      
            }else{

                pause.gameObject.SetActive(false);
            
            }
            

    }

    }

     public void Reinicia(){
        SceneManager.LoadScene("Gameplay");
        
    }

    public void MenuIncial(){
        SceneManager.LoadScene("MenuInicial");
        
    }

    public void VoltarJogo() {
        pause.gameObject.SetActive(false);//
        morte.gameObject.SetActive(false);
    
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }

    

    

    public void KillCam (){
        morto = true;
        morte.gameObject.SetActive(true);
        morte.gameObject.SetActive(true);
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
    }
}
