using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private Vector2 _inputDirection;
    

    // Start is called before the first frame update
    public void Move(CallbackContext context)
    {
        _inputDirection = context.ReadValue<Vector2>();

    }

    public void Jump(CallbackContext context)
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + new Vector2(0,2);
        rb.DOMove(targetPosition, speed).SetSpeedBased();
        Debug.Log("=====" + (Vector2)transform.position);
    }

    public void FixedUpdate()
    {
        var position = (Vector2)transform.position;
        var targetPosition = position + _inputDirection;
        Debug.Log("-----------------="+position.y);
        if (position.y <= 0f)
        {
            Debug.Log("顶顶顶" + position.y);
            rb.gravityScale = 0.0f;
            return;
        }
        else
        {
            rb.gravityScale = 0.3f;
            return;
        }
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }


}
