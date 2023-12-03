using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{

    public int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        score += 1;
    }
}
