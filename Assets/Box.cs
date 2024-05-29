using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float moveDistance = 1.0f;  // �� ĭ�� ũ��

    public bool TryMove(Vector2 direction)
    {
        Vector2 targetPosition = (Vector2)transform.position + direction * moveDistance;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, moveDistance);

        if (hit.collider == null)
        {
            // �� �������� �̵�
            transform.position = targetPosition;
            return true;
        }

        // �̵� ����
        return false;
    }
}
