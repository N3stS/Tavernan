using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerMaxSpeed = 10f;
    [SerializeField] private float playerCurrentSpeed = 0f;
    [SerializeField] private float playerAcceleration = 1f;
    [SerializeField] private float playerDeacceleration = 1f;

    [SerializeField] private float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));

        /*
        if (Input.GetKey(KeyCode.W))
        {
            playerCurrentSpeed += playerAcceleration;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
        }
        */
    }

    void MoveCharacter(Vector2 direction)
    {
        transform.Translate((direction * speed * Time.deltaTime));
    }
}
