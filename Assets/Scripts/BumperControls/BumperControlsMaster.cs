using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperControlsMaster : MonoBehaviour
{
    public bool leftBumperSelected;
    public GameObject bumperPrefab;
    public Color startColor;
    public float speed = 30;

    [SerializeField]
    private float ymax = 10;

    private void Start()
    {
        startColor = bumperPrefab.gameObject.GetComponent<Renderer>().sharedMaterial.color;
        leftBumperSelected = true;
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            leftBumperSelected = true;
        } else if (Input.GetKey(KeyCode.D))
        {
            leftBumperSelected = false;
        }

        //constrains vertical movement of bumpers
        transform.position = new(transform.position.x, Mathf.Clamp(transform.position.y, -ymax, ymax), transform.position.z);
    }
}
