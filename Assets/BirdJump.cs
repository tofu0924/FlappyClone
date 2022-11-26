using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;

    public const int LeftButton = 0;

    public float jumpPower = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(LeftButton))
        {
            rb.velocity = Vector2.up * jumpPower; // (0,1)
        }
    }
}
