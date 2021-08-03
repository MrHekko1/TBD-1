using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

    //Movement
    public float speed;
    public float jump;
    float moveVelocity;

    //Grounded Vars
    bool grounded = true;
    
    private float jumpTimeCounter;
    public float jumpTime;
    public bool isJumping;
    
    public Rigidbody2D rb;

    
    void FixedUpdate () 
    {
        //Jumping
    if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W)) 
        {
            if(grounded)
            {
                rb.velocity = Vector2.up * jump;
                isJumping = true;
            }
        }
        
        
        if(Input.GetKey(KeyCode.Space) || Input.GetKey (KeyCode.W) && isJumping == true)
        {
            if(jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jump;
                jumpTimeCounter -= Time.deltaTime;
            } else {
                isJumping = false;
            }
        }
        
        if(Input.GetKeyUp(KeyCode.Space)){
            isJumping = false;
        }
        
        
        Vector3 charecterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
             charecterScale.x = -0.5f;
        } 
        if (Input.GetAxis("Horizontal") > 0)
        {
            charecterScale.x = 0.5f;
        }
        transform.localScale = charecterScale;
        
        
        
        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
        {
            moveVelocity = speed;
        }

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

    }
    //Check if Grounded
    void OnTriggerEnter2D()
    {
        grounded = true;
        isJumping = true;
        jumpTimeCounter = jumpTime;
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }
}
