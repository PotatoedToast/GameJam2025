using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem; 


interface IInteractable{
    
    void Interact();
}

public class Interactor : MonoBehaviour
{
    private InputSystem_Actions _playerInputActions;
    [SerializeField] private float interactRange;
    [SerializeField] private Transform InteractorSource;
    [SerializeField] private LayerMask interactableMask; 


    void Awake()
    {
        _playerInputActions = new InputSystem_Actions();
        _playerInputActions.Player.Interact.started += Interact_Performed; 

     }

    private void OnEnable(){
        _playerInputActions.Player.Enable();
    }

    private void OnDisable(){
        _playerInputActions.Player.Disable();
    }

    private void Interact_Performed(InputAction.CallbackContext context){
        Vector3 origin = InteractorSource.position;
        Debug.Log("Interact input triggered - Checking proximity.");

        
        Collider[] hitColliders = Physics.OverlapSphere(
            origin, 
            interactRange, 
            interactableMask 
        );
        foreach (var hitCollider in hitColliders){
            if(hitCollider.gameObject.TryGetComponent(out IInteractable interactable)){
                interactable.Interact();
                return; 
            }
        }
    }

}
