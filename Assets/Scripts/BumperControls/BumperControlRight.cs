using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperControlRight : MonoBehaviour
{
    private bool rightBumperSelected;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        rightBumperSelected = !GetComponent<BumperControlsMaster>().leftBumperSelected;
        speed = GetComponent<BumperControlsMaster>().speed;
        if (rightBumperSelected)

        {
            //GetComponent<Renderer>().material.color = Color.magenta;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rightBumperSelected = !GetComponent<BumperControlsMaster>().leftBumperSelected;
        if (rightBumperSelected)
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
