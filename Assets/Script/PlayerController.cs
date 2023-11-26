using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;

    private Rigidbody2D playerPhysics;

    private void Start()
    {
        playerPhysics = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 movement = GetInput();
        MoveObject(movement);
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }

        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        playerPhysics.velocity = movement;
    }
}
