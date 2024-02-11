using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private Rigidbody _rigidbody;
    private float _speed = 10;

    private void Awake()
    {
 // _rigidbody = GetComponent<Rigidbody>;()
    }

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontalSpeed =Input.GetAxis("Vertical");
        float verticalSpeed =Input.GetAxis("Horizontal");
        if (horizontalSpeed!=0||verticalSpeed!=0)
          MovePlayer(horizontalSpeed, verticalSpeed); 
    }

    private void MovePlayer(float horizontalSpeed, float verticalSpeed)
    {
        _rigidbody.velocity = new Vector3(horizontalSpeed*_speed, _rigidbody.velocity.y, verticalSpeed*_speed);
    }
}
