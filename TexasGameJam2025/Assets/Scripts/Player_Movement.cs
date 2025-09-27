using UnityEngine;
using System;

[RequireComponent(typeof(CharacterController))]

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Player_Controller _playerInputActions;
    private Vector3 _input;
    private CharacterController _characterController;

    private void Awake(){
        _playerInputActions = new Player_Controller();
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
        _input = new Vector3(input.x, 0, input.y);

    }
}
