using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementT : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
