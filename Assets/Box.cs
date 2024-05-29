using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float moveDistance = 1.0f;  // 한 칸의 크기

    public bool TryMove(Vector2 direction)
    {
        Vector2 targetPosition = (Vector2)transform.position + direction * moveDistance;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, moveDistance);

        if (hit.collider == null)
        {
            // 빈 공간으로 이동
            transform.position = targetPosition;
            return true;
        }

        // 이동 실패
        return false;
    }
}
