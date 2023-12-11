using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalTarget : MonoBehaviour
{
    public float speed = 5f;
    Vector3 originalPosition;


    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ( originalPosition.x < 0 /*&& transform.position.x < 15*/)
        {
            if(transform.position.x < 15)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            else
            {
                Destroy(gameObject);
            }
        } else if (originalPosition.x > 0/* && transform.position.x > -12*/)
        {
            if (transform.position.x > -12)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
