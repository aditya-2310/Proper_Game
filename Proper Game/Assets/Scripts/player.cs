using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rigidbodycomponent;
    private float horizontalinput;
    private bool isgrounded;
    public Animator animator;
    private bool facingright;
    public Transform groundchecktransform;
    public LayerMask playermask;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodycomponent = GetComponent<Rigidbody2D>();
        facingright = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis ( "Horizontal" );
        flip(horizontalinput);
        animator.SetFloat("speed", Mathf.Abs(horizontalinput));

        if (Physics2D.OverlapCircle(groundchecktransform.position, 0.1f, playermask) == null)
        {
            isgrounded = false;
            animator.SetBool("isgrounded", false);
        }

        if (Physics2D.OverlapCircle(groundchecktransform.position, 0.1f, playermask) != null)
        {
            isgrounded = true;
            animator.SetBool("isgrounded", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            rigidbodycomponent.AddForce(Vector2.up* 4f, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        rigidbodycomponent.velocity = new Vector2(horizontalinput, rigidbodycomponent.velocity.y);
    }

    private void flip(float horizontalinput)
    {
        if (horizontalinput>0 && facingright == false || horizontalinput<0 && facingright == true)
        {
            facingright = !facingright;
            transform.Rotate(0f, 180, 0f);
        }
    }
}
