using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;

        private Animator animator;

        private void Start()
        {
            speed = 3;
            animator = GetComponent<Animator>();
        }


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift)) speed = 6;
            if (Input.GetKeyUp(KeyCode.LeftShift)) speed = 3;

            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -speed;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = speed;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = speed;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -speed;
                animator.SetInteger("Direction", 0);
            }
            
            
            

            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }
    }
}
