using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public AudioSource HitSound;
    private Rigidbody2D rb2d;
    public float ballForceX = 30;
    public float ballForceY = -15;
    void Start()
    {
        HitSound = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>(); //ambil rigidbody
        Invoke("GoBall", 2); //pnggil goball dlm 2 detik
    }

    void GoBall()
    {
        float rand = Random.Range(0, 2); //random nilai
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(ballForceX, ballForceY)) ; //tambah force
        }
        else
        {
            rb2d.AddForce(new Vector2(-ballForceX, -ballForceY));
        }
    }

    void ResetBall() //buat nilai transform jdi 0 
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player")) //jika hit player
            
        {
            Debug.Log("ballcontrol");
            HitSound.Play();
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = vel;
        }
    }

}
