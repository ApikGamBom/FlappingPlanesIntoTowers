using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{
    public Points point;
    private bool collided = false;
    // Start is called before the first frame update
    void Start()
    {
        point = GameObject.FindGameObjectWithTag("Logic").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.name == "plane" && !collided)
        {
            point.addScore(1);
            collided = true;
        }       
    }
}