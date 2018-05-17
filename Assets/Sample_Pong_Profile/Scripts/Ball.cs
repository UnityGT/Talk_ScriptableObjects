using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample_1
{
    public class Ball : MonoBehaviour
    {

        private void OnTriggerEnter2D(Collider2D collision)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Sample_1_GameOver");
        }
    }

}