using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample_1
{
    public class GameStart : MonoBehaviour
    {

        public Rigidbody2D ball;
        public GameData gameData;
        public PlayerController leftPlayer;
        public PlayerController righPlayer;

        // Use this for initialization
        void Start()
        {
            Vector2 randomForce = new Vector2(Random.Range(0f, 1f) < 0.5f ? 1 : -1, 0);
            ball.AddForce(randomForce);
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}