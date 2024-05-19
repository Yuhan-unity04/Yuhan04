using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Block_move : MonoBehaviour
{
    public GameObject player;

    //�÷��̾��� ��ġ
    public float player_X;
    public float player_Y;
    //���� ť���� ��ġ
    public float block_X;
    public float block_Y;
    //�Ÿ��� ����
    public float distance_X;
    public float distance_Y;

    bool Is_Cube_Move = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 blockPosition = transform.position;
        //�÷��̾��� ��ġ
        player_X = playerPosition.x;
        player_Y = playerPosition.y;
        //����� ��ġ
        block_X = blockPosition.x;
        block_Y = blockPosition.y;
       
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ��ϰ� �÷��̾��� x,y ��ǥ �Ÿ� ���
        distance_X = Mathf.Abs(player_X - block_X);
        distance_Y = Mathf.Abs(player_Y - block_Y);

        if (distance_X < distance_Y) Is_Cube_Move = false;
        if (distance_Y < distance_X) Is_Cube_Move = true;

        if (collision.gameObject.CompareTag("Player"))
        {
            if (Is_Cube_Move == false)
            {
                // ���ʿ��� ������ ���������� �̵�
                if (player_X > block_X) transform.position += new Vector3(0, -1, 0);
                // �����ʿ��� ������ �������� �̵�
                if (player_X < block_X) transform.position += new Vector3(0, 1, 0);
            }
            else if (Is_Cube_Move == true)
            {
                // ������ ������ �Ʒ��� �̵�
                if (player_Y > block_Y) transform.position += new Vector3(-1, 0, 0);
                // �Ʒ����� ������ ���� �̵�
                if (player_Y < block_Y) transform.position += new Vector3(1, 0, 0);
            }
        }
    }
}
