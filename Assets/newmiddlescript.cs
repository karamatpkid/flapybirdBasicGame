using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newmiddlescript : MonoBehaviour
{
    public logicScript logicScript;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicScript.addScore();

    }
 
   
}
