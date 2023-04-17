using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TiroController : MonoBehaviour {

    public Transform localTiro;
    public GameObject tiro;
    public Menus morte;
    public AudioSource audioTiro;
    public AudioSource audioMorte;
    
    private void Start() {
        morte = GameObject.FindObjectOfType<Menus>();
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Fogo();
        }
    }

    private void Fogo() {
        var bala = (GameObject) Instantiate(tiro, localTiro.position, localTiro.rotation);
        audioTiro.Play();
        if (bala) {
            bala.GetComponent<Rigidbody>().velocity = bala.transform.forward * 25;
            var sound = GetComponent<AudioSource>();
            if(sound) sound.Play();
            Destroy(bala, 6);
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Inimigo") || other.CompareTag("armadilha")) {
            audioMorte.Play();
            morte.objetoParaDesativar.SetActive(false);
            morte.KillCam();
        }
    }
}