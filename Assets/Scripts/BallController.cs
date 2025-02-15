using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{

    [SerializeField] private float force = 1f;

    private bool isBallLaunched;
    private Rigidbody ballRB;
    [SerializeField] private InputManager inputManager;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>();

        //Add a listener to OnSpacePressed event
        //when space pressed, LaunchBall called
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        if(isBallLaunched) return;
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
