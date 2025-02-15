using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {

        if (triggeredBody.CompareTag("Ball"))
        {
            //rigidbody of the ball
            Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

            //store before resetting the velocity
            float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

            //reset linear AND angular velocity as ball is rotating on the ground
            ballRigidBody.linearVelocity = Vector3.zero;
            ballRigidBody.angularVelocity = Vector3.zero;

            //add force for the gutter to change direction
            ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
        }
        
    }
}
