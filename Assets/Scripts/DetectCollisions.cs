using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{

    public int score = 0;
    //public GameManager ManagerScript;
    public GameManager ManagerObject;

    // Start is called before the first frame update
    void Start()
    {
        ManagerObject = GameObject.Find("Game Manager").GetComponent<GameManager>();
        //ManagerScript = ManagerObject.GetComponent<GameManager>();
        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ManagerObject.Score(score);
        ManagerObject.UpdateStreak(1);
        Destroy(gameObject);
        Destroy(other.gameObject);
        
    }
}
