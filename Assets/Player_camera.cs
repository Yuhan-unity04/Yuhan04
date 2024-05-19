using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_camera : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset; // 카메라와 대상 간의 거리
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }


    
}
