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

        // Calcular la dirección del movimiento
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Calcular la nueva posición del jugador
        Vector3 newPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;

        // Mover al jugador a la nueva posición
        transform.position = newPosition;
    }
}
