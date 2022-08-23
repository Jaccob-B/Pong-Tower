using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver = false;
    private Rigidbody playerRb;
    [SerializeField]
    private float speed = 30;
    private int direction = -1;
    private GameObject[] bumpers;

    // Start is called before the first frame update
    void Start()
    {
        bumpers = GameObject.FindGameObjectsWithTag("Bumper");
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Time.deltaTime * speed * direction * Vector3.forward, ForceMode.Impulse);
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bumper"))
        {
            direction *= -1;
            foreach (GameObject bumper in bumpers)
            {
                bumper.GetComponent<BumperControlsMaster>().leftBumperSelected = !bumper.GetComponent<BumperControlsMaster>().leftBumperSelected;
            }
        }

    }
}

