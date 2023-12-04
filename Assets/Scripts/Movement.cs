using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));
        //movement
        //transform.Translate(Vector3.left * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        //transform.Translate(Vector3.back * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Translate(inputVector.normalized * speed * Time.deltaTime);
        if (transform.position.x < -12)
        {
            transform.position = new Vector3(-12, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 15)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        if (transform.position.z > -9.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -9.5f);
        }
        if (transform.position.z < -12.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -12.5f);
        }
    }
}
