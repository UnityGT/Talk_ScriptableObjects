using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample_1
{
    public class Ball : MonoBehaviour
    {
        public GameStart gameStart;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(transform.position.x > 0)
            {
                gameStart.gameData.winnerProfile = gameStart.leftPlayer.pongProfile;
            }else if(transform.position.x < 0)
            {
                gameStart.gameData.winnerProfile = gameStart.righPlayer.pongProfile;
            }

            UnityEngine.SceneManagement.SceneManager.LoadScene("Sample_1_GameOver");
        }
    }

}