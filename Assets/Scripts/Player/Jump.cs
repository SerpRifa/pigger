using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.UI.Extensions;

public class Jump : MonoBehaviour
{
    private Rigidbody2D myBody;

    private bool readyJump;
    private bool readyGround;
    public int forceJump;
    public Animator anim;
    public Button button;
    public ParticleSystem victory;

    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {

        myBody = GetComponent<Rigidbody2D>();
        scoreText.text = score.ToString();
        victory.enableEmission = false;

        button.Select();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (readyJump && readyGround)
        {
            myBody.AddForce(new Vector2(0, forceJump));
            anim.SetBool("jump", true);
            readyJump = false;
            readyGround = false;
        }
    }

    public void JumpPlayer()
    {
        readyJump = true;

    }

    void OnCollisionEnter2D(Collision2D colollision2D)
    {
        if (colollision2D.gameObject.tag == "Ground")
        {
            readyGround = true;
            anim.SetBool("jump", false);
        }
        else
        {
            readyGround = false;
        }

        if (colollision2D.gameObject.tag == "Score")
        {
            score++;
            scoreText.text = score.ToString();
            TestAchive();
            Destroy(colollision2D.gameObject);
            return;
        }

        if (colollision2D.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(0);
        }

        
    }

    void TestAchive() 
    {
        if(score == 30)
        {
            victory.enableEmission = true;
        }
    }
}
