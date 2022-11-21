using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTopDown : MonoBehaviour
{
    [SerializeField] private int speed;
    private Vector2 movement;

    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            movement.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        transform.position = movement.normalized;
    }
}
