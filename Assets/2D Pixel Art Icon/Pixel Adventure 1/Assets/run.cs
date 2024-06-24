using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    [SerializeField] private float movespeed = 8f,jumpForce = 7f;
    private Rigidbody2D rb;

    private Transform groundCheckpoint;

    [SerializeField]
    private LayerMask groundLayer;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        groundCheckpoint = transform.GetChild(0).transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.velocity = new Vector2(movespeed,rb.velocity.y); 
    }
    private void PlayerJump()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (IsGrounded())
            {
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            }

        }
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheckpoint.position, 0.1f, groundLayer);
    }
}
