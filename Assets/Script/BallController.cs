using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Vector2 speed;

    private Rigidbody2D ballPhysics;

    private void Start()
    {
        ballPhysics = GetComponent<Rigidbody2D>();
        ballPhysics.velocity = speed;
    }
}
