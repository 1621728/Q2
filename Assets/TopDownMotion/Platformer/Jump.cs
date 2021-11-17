using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpStrength = 400;
    public bool grounded;
    public Rigidbody2D rb2;
    public bool canjump;
    public AudioSource audios;
    public class AudioScript : MonoBehaviour
    {
        AudioSource audiosource;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && grounded == true && canjump==true)
        {
            rb2.AddForce(new Vector2(0, jumpStrength));
            audios.Play();
            canjump = false;
            Invoke ("resetjump", 0.0f);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if(collision.tag == "SuperJump")
        {
            jumpStrength = 1000;
        } else
        {
            jumpStrength = 400;
        }
    }
    private void resetjump()
    {
        canjump = true;
    }

}
