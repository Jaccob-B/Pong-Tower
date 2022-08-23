using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperControlLeft : MonoBehaviour
{

    //Clean this code up when you get a chance. Maybe implement W/S controls in Master?
    private bool leftBumperSelected;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        leftBumperSelected = GetComponent<BumperControlsMaster>().leftBumperSelected;
        speed = GetComponent<BumperControlsMaster>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        leftBumperSelected = GetComponent<BumperControlsMaster>().leftBumperSelected;
        if (leftBumperSelected)
        {
            //GetComponent<Renderer>().material.color = Color.magenta;

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(speed * Time.deltaTime * Vector3.up);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(speed * Time.deltaTime * Vector3.down);
            }
        }
        else
        {
            GetComponent<Renderer>().material.color = GetComponent<BumperControlsMaster>().startColor;
        }
    }
}
