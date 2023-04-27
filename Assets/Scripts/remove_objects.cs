using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove_objects : MonoBehaviour
{
    [SerializeField] bool isMovingRight = true;
    [SerializeField] float speed = 1f;
    Vector3 move_factor;
    // Start is called before the first frame update
    void Start()
    {
        move_factor = new Vector3(0.1f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.tag);
        Destroy(other.gameObject);
    }
}
