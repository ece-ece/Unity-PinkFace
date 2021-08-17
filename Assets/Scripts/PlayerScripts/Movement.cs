using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 3;
    public float jumpForce = 3;
    Rigidbody2D rb2D;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
        rb2D = GetComponent<Rigidbody2D>();
        Debug.Log("Basladi");
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (Input.GetButtonDown("Jump")&&isGrounded==true)
        {

            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        }
    }
    void Move()
    {
        var movement = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(movement*movementSpeed, rb2D.velocity.y);

       /* if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }*/

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
    private void OnLevelWasLoaded(int level)
    {
        StartPosition();
    }
    void StartPosition()
    {
        transform.position = GameObject.FindWithTag("StartPoint").transform.position;
    }
}
