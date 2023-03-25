using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private int time = 1;
    [SerializeField] private Canvas ReverseCanvas;


    private IEnumerator WaitingTime(float seconds)
    {
        ReverseCanvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(seconds);
        ReverseCanvas.gameObject.SetActive(false);
    }

    public PlayerControls[] player;
    public AudioSource HitSound;
    public AudioSource BlackSoundSource;
    public AudioSource GreenSoundSource;
    public AudioSource RedSoundSource;
    public ParticleSystem collisionParticle;
    private Rigidbody2D rb2d;
    public float ballForceX = 30;
    public float ballForceY = -15;
    [SerializeField] private CameraShake cameraShake;
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

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player")) //jika hit player
            
        {
            //cameraShake.shouldShake = true;
            
            HitSound.Play();
            Vector2 vel;
            vel.x = rb2d.velocity.x +3f;
            vel.y = (rb2d.velocity.y) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = vel;
            EmitParticle(90);
        }

        if (coll.collider.CompareTag("Wall"))
        {
            EmitParticle(130);
        }

        if (coll.gameObject.CompareTag("BlackBall"))
        {
            
            Debug.Log("kenahitam");
            BlackSoundSource.Play();
            Destroy(coll.gameObject, 0.2f);
            //coll.gameObject.GetComponent<PowerBall>().ReverseInput();

        }

    }

    



    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("RedBall"))
        {
            //RedSound.Play();
            RedSoundSource.Play();
            cameraShake.shouldShake = true;
            //coll.gameObject.GetComponent<PowerBall>().ScreenShake();
            Destroy(coll.gameObject, 0.2f);
        }

        if (coll.gameObject.CompareTag("GreenBall"))
        {
            //GreenSound.Play();
            StartCoroutine(WaitingTime(time));
            GreenSoundSource.Play();
            //Panel .gameObject.SetActive(true);
            player[0].speed *= -1;
            player[1].speed *= -1;
            Destroy(coll.gameObject, 0.2f);
            //coll.gameObject.GetComponent<PowerBall>().ReverseInput();

        }




    }




    void BugOut()
    {
        if(transform.position.y > 3.01)
        {
            Debug.Log("keluar");
            GameManager.instance.RestartGame();
        }
        else if(transform.position.y <= -3.08){
            GameManager.instance.RestartGame();
            Debug.Log("keluar");
        }
    }

    private void EmitParticle(int amount)
    {
        collisionParticle.Emit(amount);
    }
}
