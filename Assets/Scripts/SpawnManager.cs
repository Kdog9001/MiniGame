using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Target;
    public GameObject HorizontalTarget;
    public GameObject GoldenTarget;
    public GameManager ManagerObject;
    public bool Hoz;
    public bool gold;
    //change to fit in with target boundaries that will be built
    private float spawnRangeX = 15;
    private float spawnPosZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 3f;
    private float goldInterval = 15f;

    // Start is called before the first frame update
    void Start()
    {
        ManagerObject = GameObject.Find("Game Manager").GetComponent<GameManager>();
        if (ManagerObject.playing == true)
        {
            InvokeRepeating("SpawnTarget", startDelay, spawnInterval);
        }
        Hoz = false;
        gold = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Hoz == false && ManagerObject.score > 15)
        {
            Hoz = true;
            InvokeRepeating("SpawnHozTarget", startDelay, spawnInterval);
        }
        if (gold == false && ManagerObject.score > 50)
        {
            gold = true;
            InvokeRepeating("SpawnGolTarget", startDelay, goldInterval);
        }
    }

    void SpawnTarget()
    {
        spawnPosZ = Random.Range(0, 15);
        //random spawn location for targets
        Vector3 spawnPos = new Vector3(Random.Range(-12, spawnRangeX), 1.87f, spawnPosZ);
        Instantiate(Target, spawnPos, Target.transform.rotation);
        //Game Object ^               Spawn Location  ^rotation it spawns in at
    }
    void SpawnHozTarget()
    {
        spawnPosZ = Random.Range(0, 15);
        //random spawn location for targets
        Vector3 spawnPos = new Vector3(Random.Range(-12, spawnRangeX), 1.87f, spawnPosZ);
        Instantiate(HorizontalTarget, spawnPos, Target.transform.rotation);
        //Game Object ^               Spawn Location  ^rotation it spawns in at
    }

    void SpawnGolTarget()
    {
        spawnPosZ = Random.Range(0, 15);
        //random spawn location for targets
        Vector3 spawnPos = new Vector3(Random.Range(-12, spawnRangeX), 1.87f, spawnPosZ);
        Instantiate(GoldenTarget, spawnPos, Target.transform.rotation);
        //Game Object ^               Spawn Location  ^rotation it spawns in at
    }

}
