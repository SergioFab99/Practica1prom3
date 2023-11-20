using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Radio del círculo
    private float circleRadius = 3f;
    // Velocidad de movimiento en círculos
    private float circleSpeed = 2f;
    // Velocidad de movimiento horizontal
    private float horizontalSpeed = 4f;
    // Velocidad de movimiento vertical
    private float verticalSpeed = 3f;

    private IEnumerator Start()
    {
        yield return StartCoroutine(MoveInCircles());
        yield return StartCoroutine(MoveLeftToRight());
        yield return StartCoroutine(MoveUpDown());
    }

    private IEnumerator MoveInCircles()
    {
        float timer = 0f;
        while (timer <= 5f)
        {
            float angle = timer * circleSpeed;
            Vector3 circlePosition = new Vector3(Mathf.Cos(angle) * circleRadius, Mathf.Sin(angle) * circleRadius, 0f);
            transform.position = circlePosition;
            timer += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator MoveLeftToRight()
    {
        float timer = 0f;
        while (timer <= 5f)
        {
            float horizontalMovement = Mathf.PingPong(timer * horizontalSpeed, 10f) - 5f;
            transform.position = new Vector3(horizontalMovement, transform.position.y, 0f);
            timer += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator MoveUpDown()
    {
        float timer = 0f;
        while (timer <= 10f)
        {
            float verticalMovement = Mathf.PingPong(timer * verticalSpeed, 6f) - 3f;
            transform.position = new Vector3(transform.position.x, verticalMovement, 0f);
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
