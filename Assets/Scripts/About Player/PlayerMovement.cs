using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private float speed;
    private Vector2 _inputDirection;
    
    public void Move(InputAction.CallbackContext context)
    {
        _inputDirection = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        var position = (Vector2)transform.position;
        var targetposition = position + _inputDirection;
        if (position == targetposition) return;
        rb.DOMove(targetposition, speed).SetSpeedBased();
    }
}
