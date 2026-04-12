using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    public NavMeshAgent navAgent;
    private InputSystem_Actions inputActions;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        inputActions = new InputSystem_Actions();
        

    }
    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Attack.performed += OnAttack;
    }

private void OnAttack(InputAction.CallbackContext context)
    {
        Ray mouswRay = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

        if (Physics.Raycast(mouswRay, out RaycastHit HitInfo))
        {
            navAgent.SetDestination(HitInfo.point);
        }



    }



    private void OnDisable()
    {
        inputActions.Disable();
        inputActions.Player.Attack.performed -= OnAttack;
    }


}
