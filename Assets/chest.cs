using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chest : MonoBehaviour
{
    public GameObject open_chest;
    public GameObject bar, bar2;
    public Image bbb;

    bool is_item;
    bool has_collided;

    void Start()
    {
        open_chest.SetActive(false);
        bbb.enabled = false; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            has_collided = true;
        }
    }

    void Update()
    {
        if (has_collided && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("eaf");
        
            gameObject.SetActive(false);
            open_chest.SetActive(true);

            is_item = true;

            Destroy(bar);
            Destroy(bar2);

            bbb.enabled = true;

           
            has_collided = false;
        }
    }
}
