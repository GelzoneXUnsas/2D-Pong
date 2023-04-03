using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public GameObject HitSFX;

    public GameObject PlayerSFX;

    public GameObject GoalSFX;

    public ballMovement bm;

    public ScoreManager sm;

    private void bounce(Collision2D col)
    {
        Vector3 bpos = bm.transform.position;
        Vector3 rpos = col.transform.position;
        float rheight = col.collider.bounds.size.y;

        float posX;

        if (col.gameObject.name == "P1")
            posX = 1;
        else
            posX = -1;

        float posY = (bpos.y - rpos.y) / rheight;
        bm.increaseHitCounter();
        bm.Move(new Vector2(posX, posY));
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "P1" || col.gameObject.name == "P2")
        {
            bounce (col);
            Instantiate(PlayerSFX, transform.position, transform.rotation);
        }
        else if (col.gameObject.name == "right")
        {
            sm.P1Goal();
            StartCoroutine(bm.Launch());
            Instantiate(GoalSFX, transform.position, transform.rotation);
        }
        else if (col.gameObject.name == "left")
        {
            sm.P2Goal();
            StartCoroutine(bm.Launch());
            Instantiate(GoalSFX, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(HitSFX, transform.position, transform.rotation);
        }
    }
}
