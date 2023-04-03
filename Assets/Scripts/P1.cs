using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    private Vector2 dir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirY = Input.GetAxisRaw("Vertical");
        dir = new Vector2(0, dirY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = speed * dir;
    }
}
