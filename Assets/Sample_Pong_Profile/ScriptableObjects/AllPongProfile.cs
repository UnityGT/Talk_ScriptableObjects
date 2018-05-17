using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AllProfile", menuName = "Profiles/All Profile")]
public class AllPongProfile : ScriptableObject {

    public Color mainColor;
    public float power;

    public void WhenHitBall(Rigidbody2D rigidBall)
    {
        rigidBall.GetComponent<SpriteRenderer>().color = mainColor;
        rigidBall.velocity *= power;
    }

}
