using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MeanProfile", menuName = "Profiles/Mean Profile")]
public class MeanProfile : PongProfile {

    public override void WhenHitBall(Rigidbody2D rigidBall)
    {
        rigidBall.GetComponent<SpriteRenderer>().color = mainColor;
        rigidBall.velocity *= 5;
    }

}
