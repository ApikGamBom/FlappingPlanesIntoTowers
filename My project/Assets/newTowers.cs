using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTowers : MonoBehaviour
{
    public GameObject tower;
    public float spawnrate = 5;
    private float timer = 0;
    public float offset = 5;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTowers();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnTowers();
            timer = 0;
        }  
    }
    void SpawnTowers()
    {
        float lowestP = transform.position.y - offset;
        float highestP = transform.position.y + offset;
        Instantiate(tower, new Vector3(transform.position.x, Random.Range(lowestP, highestP), 0), transform.rotation);
    }

}