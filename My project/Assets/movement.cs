using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float towerSpeed = 5;
    public int killOffset = -14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * towerSpeed * Time.deltaTime;
        if (transform.position.x < killOffset)
        {
            Destroy(gameObject);
        }
    }
}
