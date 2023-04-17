using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class BarrilControll : MonoBehaviour
{
    public GameObject enemy;
    Pontos pontos;

    private void Start()
    {
        pontos = GameObject.Find("Contador").GetComponent<Pontos>();
    }

    private void OnCollisionEnter(Collision other)
    {
            var hit = other.gameObject;
        if (other.gameObject.CompareTag("Inimigo"))
        {

            float randomX = UnityEngine.Random.Range(-20, 20);
            float randomZ = UnityEngine.Random.Range(-20, 20);

            var zombie = (GameObject)Instantiate(enemy);
            zombie.transform.position = new Vector3(randomX, 0, randomZ);
            zombie.transform.rotation = Quaternion.Euler(-90, 0, 0);

            Destroy(hit);
            Destroy(gameObject);
            pontos.AddKills();
        }else if (!hit.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}

        