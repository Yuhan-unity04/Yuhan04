using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Block_move : MonoBehaviour
{
    public GameObject player;

    //플레이어의 위치
    public float player_X;
    public float player_Y;
    //비교할 큐브의 위치
    public float block_X;
    public float block_Y;
    //거리비교 변수
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
        //플레이어의 위치
        player_X = playerPosition.x;
        player_Y = playerPosition.y;
        //블록의 위치
        block_X = blockPosition.x;
        block_Y = blockPosition.y;
       
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 블록과 플레이어의 x,y 좌표 거리 계산
        distance_X = Mathf.Abs(player_X - block_X);
        distance_Y = Mathf.Abs(player_Y - block_Y);

        if (distance_X < distance_Y) Is_Cube_Move = false;
        if (distance_Y < distance_X) Is_Cube_Move = true;

        if (collision.gameObject.CompareTag("Player"))
        {
            if (Is_Cube_Move == false)
            {
                // 왼쪽에서 닿으면 오른쪽으로 이동
                if (player_X > block_X) transform.position += new Vector3(0, -1, 0);
                // 오른쪽에서 닿으면 왼쪽으로 이동
                if (player_X < block_X) transform.position += new Vector3(0, 1, 0);
            }
            else if (Is_Cube_Move == true)
            {
                // 위에서 닿으면 아래로 이동
                if (player_Y > block_Y) transform.position += new Vector3(-1, 0, 0);
                // 아래에서 닿으면 위로 이동
                if (player_Y < block_Y) transform.position += new Vector3(1, 0, 0);
            }
        }
    }
}
