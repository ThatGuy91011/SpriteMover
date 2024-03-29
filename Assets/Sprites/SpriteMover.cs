﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using SpeedTreeImporter = UnityEditor.SpeedTreeImporter;

public class SpriteMover : MonoBehaviour
{
    public float Speed; //A variable to hold the Speed component
    private Transform tf; // A variable to hold the Transform component

    Rigidbody2D m_Rigidbody; //Defines the sprite as a RigidBody that you can manipulate in the code

    void Start()
    {
        // Get the Transform Component
        tf = GetComponent<Transform>();
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //If the up arrow is pressed...
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //...move the sprite forward constantly at speed you define
            tf.position = tf.position + transform.up * Speed;
        }

        //If the down arrow is pressed...
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //...move the sprite backwards constantly at the speed you define
            tf.position = tf.position - transform.up * Speed;
        }

        //If the left arrow is pressed...
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //...rotate the sprite to the left
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 30f, Space.World);
        }

        //If the right arrow is pressed...
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //...rotate the sprite to the right
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * 30f, Space.World);
        }
    }
}