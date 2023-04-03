using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public float startSpeed;

    public float extraSpeed;

    private int hitCounter;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    void Restart()
    {
        rb.velocity = new Vector2(0f, 0f);
        transform.position = new Vector2(0f, 0f);
    }

    public IEnumerator Launch()
    {
        Restart();
        hitCounter = 0;
        yield return new WaitForSeconds(1);

        Move(new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)));
    }

    public void Move(Vector2 direction)
    {
        float bSpeed;
        direction = direction.normalized;
        bSpeed = startSpeed + hitCounter * extraSpeed;

        rb.velocity = direction * bSpeed;
    }

    public void increaseHitCounter()
    {
        hitCounter++;
    }
}
