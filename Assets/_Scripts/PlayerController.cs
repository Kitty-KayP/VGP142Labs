using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    CharacterController cc;
    public float speed = 100.0f;

    //character controller variables
    Vector2 direction;
    float gravity;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        gravity = Physics.gravity.y;
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        direction = ctx.ReadValue<Vector2>();
    }

    public void MoveCancelled(InputAction.CallbackContext ctx)
    {
        direction = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desiredMoveDirection;
        float YVel = (!cc.isGrounded) ? gravity * Time.deltaTime : 0f;

        //change our desired move direction to be in line with our camera forward vector - this will ensure that when we press the forward direction - it will be in the direction the camera is facing

        desiredMoveDirection = new Vector3(direction.x * speed * Time.deltaTime, YVel, direction.y * speed * Time.deltaTime);

        //our final move for this update
        cc.Move(desiredMoveDirection);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    private void OnTriggerEnter(Collider other)
    {

    }
}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class PlayerController : MonoBehaviour
//{

//    CharacterController cc;
//    public float speed = 20.0f;

//    //character controller variables
//    Vector2 direction;
//    float gravity;


//    // Start is called before the first frame update
//    void Start()
//    {
//        cc = GetComponent<CharacterController>();
//        gravity = Physics.gravity.y;
//    }

//    public void OnMove(InputAction.CallbackContext ctx)
//    {
//        direction = ctx.ReadValue<Vector2>();
//    }

//    public void MoveCanceled(InputAction.CallbackContext ctx)
//    {
//        direction = Vector2.zero;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        Vector3 desiredMoveDirection;
//        float YVel = (!cc.isGrounded) ? gravity * Time.deltaTime : 0f;

//        //change our desired move direction to be in line with our camera forward vector - this will ensure that when we press the forward direection - it will be in the direction the camerra is facing

//        desiredMoveDirection = new Vector3(direction.x * speed * Time.deltaTime, YVel, direction.y * speed * Time.deltaTime);


//        //our final move for this update
//        cc.Move(desiredMoveDirection);

//    }

//    private void OnControllerColliderHit(ControllerColliderHit hit)
//    {

//    }
//}
