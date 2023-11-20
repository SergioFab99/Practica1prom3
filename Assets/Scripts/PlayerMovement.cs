using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del jugador

    private void Update()
    {
        // Obtener las entradas de movimiento horizontal y vertical
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calcular la direcci�n del movimiento
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Calcular la nueva posici�n del jugador
        Vector3 newPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;

        // Mover al jugador a la nueva posici�n
        transform.position = newPosition;
    }
}
