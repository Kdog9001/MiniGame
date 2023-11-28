using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Script : MonoBehaviour
{

    public float speed;
    public GameObject bulletPrefab;
    public Transform spawner;
    public GameObject[] bullets;
    public int Mag = 15;
    public GameObject reloadText;

    // Start is called before the first frame update
    void Start()
    {
        reloadText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Shoot();
        Reload();

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            reloadText.SetActive(false);
        }
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Mag > 0)
            {
                int whichBullet = Random.Range(0, bullets.Length);
                Instantiate(bullets[whichBullet], spawner.position, bullets[whichBullet].transform.rotation);
                Mag = Mag - 1;
            }
            if (Mag == 0)
            {
                reloadText.SetActive(true);
            }
            
        }

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
        if(transform.position.z > -9.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -9.5f);
        }
        if (transform.position.z < -12.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -12.5f);
        }
    }

    void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Mag = 15;
            reloadText.SetActive(false);
        }
    }


}

