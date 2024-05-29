using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playermove : MonoBehaviour
{
    public float moveDistance = 1.0f;  // ÇÑ Ä­ÀÇ Å©±â
    private Vector2 targetPosition;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Move(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Move(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Move(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Move(Vector2.right);
        }

        // Smooth movement towards targetPosition (optional)
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 10f);
    }

    void Move(Vector2 direction)
    {
        targetPosition += direction * moveDistance;
    }
}
