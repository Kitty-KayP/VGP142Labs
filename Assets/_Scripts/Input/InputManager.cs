using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    ProjectActions inputs;
    public PlayerController controller;

    protected override void Awake()
    {
        base.Awake();
        inputs = new ProjectActions();
    }

    private void OnEnable()
    {
        inputs.Enable();
        inputs.Overworld.Move.performed += controller.OnMove;
        inputs.Overworld.Move.canceled += controller.MoveCancelled;
    }

    private void OnDisable()
    {
        inputs.Disable();
        inputs.Overworld.Move.performed -= controller.OnMove;
        inputs.Overworld.Move.canceled -= controller.MoveCancelled;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}




//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class InputManager : Singleton<InputManager>
//{
//    ProjectActions inputs;

//    public PlayerController controller;

//    protected override void Awake()
//    {
//        base.Awake();
//        inputs = new ProjectActions();
//    }

//    private void OnEnable()
//    {
//        inputs.Enable();
//        inputs.Overworld.Move.performed += controller.OnMove;
//        inputs.Overworld.Move.canceled += controller.MoveCanceled;

//    }

//    private void OnDisable()
//    {
//        inputs.Disable();
//        inputs.Overworld.Move.performed -= controller.OnMove;
//        inputs.Overworld.Move.canceled -= controller.MoveCanceled;
//    }


//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}
