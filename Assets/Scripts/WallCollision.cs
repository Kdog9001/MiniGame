using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    public GameManager ManagerObject;


    // Start is called before the first frame update
    void Start()
    {
        ManagerObject = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ManagerObject.streak = 0;
        Destroy(other.gameObject);
    }
}
