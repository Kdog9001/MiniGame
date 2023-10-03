using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Target;
    //change to fit in with target boundaries that will be built
    private float spawnRangeX = 15;
    private float spawnPosZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTarget", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnTarget()
    {
        spawnPosZ = Random.Range(0, 15);
        //random spawn location for targets
        Vector3 spawnPos = new Vector3(Random.Range(-12, spawnRangeX), 1.87f, spawnPosZ);
        Instantiate(Target, spawnPos, Target.transform.rotation);
        //Game Object ^               Spawn Location  ^rotation it spawns in at
    }

}
