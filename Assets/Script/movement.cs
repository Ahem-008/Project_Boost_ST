using UnityEngine;

public class movement : MonoBehaviour
{
 
    [SerializeField] float forwardThrust = 1000;
    [SerializeField] float leftThrust = 1000;
    [SerializeField] float rightThrust = 1000;

    Rigidbody rd;
    AudioSource main_thrusters;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        main_thrusters = GetComponent<AudioSource>();
    }

    void Update()
    {
        ProcessMovement();
        Reset();
    }

    void ProcessMovement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rd.AddRelativeForce(Vector3.up * forwardThrust * Time.deltaTime);

            if (!main_thrusters.isPlaying)
            {
                main_thrusters.Play();
            }
        }
        else
        {
            main_thrusters.Stop();
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

    void Reset()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector3(-42, 2, 0);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }    
}
