using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Rigidbody2D rigidbody;
    Animator anim;
    bool FacingRight = true;
    

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("run", true);
        }

        else
        {
            anim.SetBool("run", false);
        }

        if (direction.x < 0 && FacingRight)
        {
            Flip();
        }
        else if (direction.x > 0 && !FacingRight)
        {
            Flip();
        }

        //bool flipped = direction.x < 0 ;
        //this.transform.rotation = Quaternion.Euler(new Vector3(0f, flipped ? 180f : 0f, 0f));
    }
    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * speed * Time.fixedDeltaTime);
    }

    void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
