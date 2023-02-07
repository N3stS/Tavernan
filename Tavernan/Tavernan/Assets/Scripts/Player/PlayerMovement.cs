using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update()
    {
        MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    void MoveCharacter(Vector2 direction)
    {
        transform.Translate((direction * (speed * Time.deltaTime)));
    }
}
