using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour
{
    public GameObject pistolObject;
    public GameObject ARObject;
    public bool pistol = true;
    public bool AR = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        WeaponChoice();
        if (Input.GetKey(KeyCode.Mouse1) && pistol == true)
        {
            transform.position = pistolObject.transform.position + new Vector3(0, 2, -4);
        }
        else if (pistol == true)
        {
            transform.position = pistolObject.transform.position + new Vector3(-4, 2, -4);
        }
        else if (Input.GetKey(KeyCode.Mouse1) && AR == true)
        {
            transform.position = ARObject.transform.position + new Vector3(0, 2, -4);
        }
        else if (AR == true)
        {
            transform.position = pistolObject.transform.position + new Vector3(-4, 2, -4);
        }
    }

    public void WeaponChoice()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            pistol = true;
            AR = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            pistol = false;
            AR = true;
        }
    }
}
