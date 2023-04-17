using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAndDestroy : MonoBehaviour
{
    public GameObject prefab;    // Prefab a ser instanciado
    public float spawnInterval;  // Intervalo de tempo entre cada instância
    public float lifeTime;       // Tempo de vida da instância

    private float timer;         // Contador de tempo desde a última instância

    void Update()
    {
        // Incrementa o contador de tempo
        timer += Time.deltaTime;

        // Verifica se já passou o tempo necessário para instanciar um novo objeto
        if (timer >= spawnInterval)
        {
            // Instancia o objeto
            GameObject obj = Instantiate(prefab, transform.position, transform.rotation);

            // Define o tempo de vida do objeto
            Destroy(obj, lifeTime);

            // Reinicia o contador de tempo
            timer = 0;
        }
    }
}
