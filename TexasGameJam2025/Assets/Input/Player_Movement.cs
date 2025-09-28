using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private InputSystem_Actions _playerInputActions;
    private Vector3 _input;
    private CharacterController _characterController;

    private void Awake(){
        //Initializes player input and character controller
        _playerInputActions = new InputSystem_Actions();
        _characterController = GetComponent<CharacterController>();
    }

    private void OnEnable(){
        _playerInputActions.Player.Enable();
    }
    
    private void OnDisable(){
        _playerInputActions.Player.Disable();
    }

    private void Update(){ 
        getInput();
        Move();
    }

    private void Move(){
        Vector3 moveDirection = _input * speed * Time.deltaTime;
        _characterController.Move(moveDirection);
    }

    private void getInput(){
        Vector2 input = _playerInputActions.Player.Move.ReadValue<Vector2>();

        //45 Degree rotation for isometric movement
        float angle = 45f * Mathf.Deg2Rad;

        //Apply rotation to input and set the input value. 
        Vector2 isometricInput = new Vector2(input.x*Mathf.Sin(angle) + input.y * Mathf.Cos(angle),
                                             input.y*Mathf.Sin(angle) - input.x * Mathf.Cos(angle));    
        _input = new Vector3(isometricInput.x, 0, isometricInput.y);

    }
}
