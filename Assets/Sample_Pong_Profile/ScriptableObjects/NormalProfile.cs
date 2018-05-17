using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NormalProfile", menuName = "Profiles/Normal Profile")]
public class NormalProfile : PongProfile {

    public override void WhenHitBall(Rigidbody2D rigidBall)
    {
        rigidBall.GetComponent<SpriteRenderer>().color = mainColor;
    }
}
