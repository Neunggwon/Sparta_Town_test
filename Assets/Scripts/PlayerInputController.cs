using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    //private Animator _animator;
    private void Awake()
    {
        //카메라 가지고 옴
        _camera = Camera.main;
        //_animator = GetComponent<Animator>();

    }

    public void OnMove(InputValue value)
    {
        Debug.Log($"OnMove {value.ToString()}");
        Vector2 moveInput = value.Get<Vector2>().normalized;

        //_animator.SetFloat("Speed", moveInput.magnitude);
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Debug.Log($"OnLook {value.ToString()}");
        Vector2 newAim = value.Get<Vector2>();
        Vector2 woeldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (woeldPos - (Vector2)transform.position).normalized;

        if(newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
        //IsAttacking = value.isPressed;
    }
}
