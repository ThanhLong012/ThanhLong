using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Brad : MonoBehaviour
{
    [SerializeField] private float jumb;
    [SerializeField] private GameObject message;
    private Rigidbody2D rb;
    private bool levelStart;
    public GameObject PipeGenerator;
    private int score;
    public Text scoreText;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        levelStart = false;
        rb.gravityScale = 0;
        score = 0;
        scoreText.text = score.ToString();
        message.GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SoundsController.instance.PlayThisSound("wing", 0.5f);
            if (levelStart == false)
            {
                levelStart = true;
                rb.gravityScale = 6;
                PipeGenerator.GetComponent<PipeGenerator>().enableGeneratePipe = true;
                message.GetComponent<SpriteRenderer>().enabled = false; // bat tat trang thai hoat dong 
            }
            Move();
        }
    }
    private void Move()
    {
        rb.velocity = Vector2.up * jumb;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundsController.instance.PlayThisSound("hit", 0.5f);
        ReloadScene();
        score = 0;
        scoreText.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SoundsController.instance.PlayThisSound("point", 0.5f);
        score += 1;
        scoreText.text = score.ToString();
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
