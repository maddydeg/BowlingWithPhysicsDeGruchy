using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{

    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;

    private Rigidbody ballRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //reference to the RigidBody
        ballRB = GetComponent<Rigidbody>();

        //Add a listener to OnSpacePressed event
        //when space pressed, LaunchBall called
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
