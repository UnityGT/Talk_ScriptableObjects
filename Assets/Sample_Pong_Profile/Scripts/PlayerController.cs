using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample_1
{
    public class PlayerController : MonoBehaviour
    {

        public bool isPlayer2;
        public bool upPressed;
        public bool downPressed;
        private Rigidbody2D rbody2d;

        // Use this for initialization
        void Start()
        {
            rbody2d = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (!isPlayer2)
            {
                upPressed = Input.GetKey(KeyCode.W);
                downPressed = Input.GetKey(KeyCode.S);
            }
            else
            {
                upPressed = Input.GetKey(KeyCode.UpArrow);
                downPressed = Input.GetKey(KeyCode.DownArrow);
            }
        }

        private void FixedUpdate()
        {
            Vector2 movePosition = rbody2d.position;
            if (upPressed)
            {
                movePosition.y += 1 * Time.deltaTime;
            }
            else if (downPressed)
            {
                movePosition.y -= 1 * Time.deltaTime;
            }

            if (movePosition.y > 4)
            {
                movePosition.y = 4;
            }

            if (movePosition.y < -4)
            {
                movePosition.y = -4;
            }

            rbody2d.MovePosition(movePosition);
        }

    }

}