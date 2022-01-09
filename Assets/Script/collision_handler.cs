using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_handler : MonoBehaviour
{
    
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string colliderTag = collision.gameObject.tag;

        switch (colliderTag)
        {

            case "Friendly":
                Debug.Log("Friendly");
                break;

            case "Finish_plate":
                Debug.Log("Finish");
                break;

            default:
                SceneManager.LoadScene(0);
                break;

        }
    }

    void Update()
    {

    }
}
