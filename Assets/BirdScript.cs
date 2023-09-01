using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float velocityUpStregth;
    public logicScript logicScript;
    public bool isbirdLive = true;
    public float deadZone = -10;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && isbirdLive)
        {
            birdRigidbody.velocity = Vector2.up * 6;
        }
        if (transform.position.y < deadZone)
        {
            logicScript.gameOver();
            isbirdLive = false;
            Time.timeScale = 0;
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        isbirdLive = false;
        Time.timeScale = 0;
    }

}
