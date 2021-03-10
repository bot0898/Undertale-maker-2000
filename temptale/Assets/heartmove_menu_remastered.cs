using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartmove_menu_remastered : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed;
    public float speedf;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = speedf;
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        rb.MovePosition(rb.position + moveVelocity);
    }
}
