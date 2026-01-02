using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Component References")]
    [SerializeField] Rigidbody2D rb;
    
    [Header("Player Settings")]
    [SerializeField]float speed;

    float horizontal;
    float vertical;
    float change;


    #region PLAYER_CONTROLS
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal*speed, vertical*speed);
        
    }
    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }
    #endregion
}
