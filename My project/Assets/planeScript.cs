using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System.Threading;

public class planeScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float strength = 10;
    public Points point;
    public bool notCrashed = true;
    // Start is called before the first frame update
    void Start()
    {
        point = GameObject.FindGameObjectWithTag("Logic").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && notCrashed)
        {
            myRigidbody.velocity = Vector2.up * strength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.name == "topTower" || collidedObject.name == "bottomTower")
        {
            point.gameOver(true);
            notCrashed = false;
        }
        else if (collidedObject.name == "Top" || collidedObject.name == "Bottom")
        {
            point.gameOver(false);
            notCrashed = false;
        }
    }
}