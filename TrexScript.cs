using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TrexScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool trexIsAlive = true;
    public AudioSource audTrex;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && trexIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            audTrex.Play();
        }
        

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        logic.gameOver();
        trexIsAlive = false;
        
    }
}
