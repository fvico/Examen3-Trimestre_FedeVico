using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class MovePlayer : MonoBehaviour
{
        private CharacterController characterController;
        public float speed;

        private void Start()
        {
            characterController = GetComponent<CharacterController>();
        }
        private void Update()
        {
            Move();
            Jump();
        LimiatrPosicion();
        }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("jump");
        }
    }


    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * x + transform.forward * z;
        Vector3 movement = direction * speed * Time.deltaTime;
        characterController.Move(movement);
    }

    void LimiatrPosicion()
    {
        
        if (transform.position.z > -10.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -10.5f);
        }
    }
}

