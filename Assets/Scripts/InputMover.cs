using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This component moves its object when the player clicks the arrow keys.
/// </summary>
public class InputMover : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] private float speed = 1f;
    private Vector3 posRightLeft = new Vector3(0.01f, 0, 0);

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += posRightLeft * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= posRightLeft * speed;
        }
    }
}
