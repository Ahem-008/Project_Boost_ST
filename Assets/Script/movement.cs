using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float forwardThrust = 1000;
    [SerializeField] float leftThrust = 1000;
    [SerializeField] float rightThrust = 1000;

    Rigidbody rd;
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
    }

    void ProcessMovement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rd.AddRelativeForce(Vector3.up * forwardThrust * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.D))
        {
            rd.freezeRotation = true;
            transform.Rotate(Vector3.forward * leftThrust * Time.deltaTime);
            rd.freezeRotation = false;
        }
        if (Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.A))
        {
            rd.freezeRotation = true;
            transform.Rotate(Vector3.back * rightThrust * Time.deltaTime);
            rd.freezeRotation = false; ;
        }
    }
}
