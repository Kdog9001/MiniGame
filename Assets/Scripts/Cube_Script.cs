using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube_Script : MonoBehaviour
{

    public float speed;
    public GameObject bulletPrefab;
    public Transform spawner;
    public GameObject[] bullets;
    public int Mag = 15;
    public int Magsize = 15;
    public GameObject reloadText;
    public TextMeshProUGUI MagText;
    public bool pistolBool = true;
    public bool ARBool = false;


    // Start is called before the first frame update
    void Start()
    {
        reloadText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*Move();*/
        Shoot();
        Reload();

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            reloadText.SetActive(false);
        }
        weaponChoice();
        MagText.text = Mag + "/" + Magsize;
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

    public void weaponChoice()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Magsize = 15;
            Mag = 15;
            pistolBool = true;
            ARBool = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Magsize = 30;
            Mag = 30;
            pistolBool = false;
            ARBool = true;
        }
    }

   

    void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R) && pistolBool == true)
        {
            Mag = 15;
            reloadText.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R) && ARBool == true)
        {
            Mag = 30;
            reloadText.SetActive(false);
        }
    }


}

