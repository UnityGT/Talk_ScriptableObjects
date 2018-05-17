using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PongProfile : ScriptableObject {

    public Color mainColor;
    public abstract void WhenHitBall(Rigidbody2D rigidBall);
}

