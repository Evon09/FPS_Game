using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtPlayer : MonoBehaviour
{
    public float moveDistance = 2f; // Distância que o objeto vai se mover para cima e para baixo
    public float moveSpeed = 2f; // Velocidade de movimento do objeto
    public float moveDelay = 1f; // Tempo de espera antes de começar a mover novamente

    private Vector3 initialPosition; // Posição inicial do objeto
    private Vector3 targetPosition; // Posição de destino do objeto
    private bool movingUp = true; // Flag que indica se o objeto está se movendo para cima ou para baixo

    void Start()
    {
        initialPosition = transform.position; // Salva a posição inicial do objeto
        targetPosition = initialPosition + Vector3.up * moveDistance; // Calcula a posição de destino do objeto
    }

    void Update()
    {
        // Verifica se o tempo de espera já passou
        if (Time.timeSinceLevelLoad > moveDelay)
        {
            // Move o objeto para a posição de destino
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Verifica se o objeto chegou à posição de destino
            if (transform.position == targetPosition)
            {
                // Inverte a flag que indica se o objeto está se movendo para cima ou para baixo
                movingUp = !movingUp;

                // Define a nova posição de destino do objeto
                if (movingUp)
                    targetPosition = initialPosition + Vector3.up * moveDistance;
                else
                    targetPosition = initialPosition;

                // Reseta o tempo de espera
                moveDelay = Time.timeSinceLevelLoad + moveDelay;
            }
        }
    }
}