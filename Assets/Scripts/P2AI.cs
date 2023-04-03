using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2AI : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    private Vector2 dir;

    public ballMovement bm;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        Vector3 bpos = bm.transform.position;

        float d = bpos.y - rb.transform.position.y;

        if(d > 0){
            move.y = speed * Mathf.Min(d, 1.0f);    
        }
        if(d < 0){
            move.y = -(speed * Mathf.Min(-d, 1.0f));
        }

        rb.transform.position += move * Time.deltaTime;
    }
}
