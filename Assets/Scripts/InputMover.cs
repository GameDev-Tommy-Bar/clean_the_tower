using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class InputMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;
    Vector3 pos_right_left = new Vector3(0.01f,0,0);


    void Update() {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position += pos_right_left*speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           GetComponent<Transform>().position -= pos_right_left*speed;
        }

    }
}