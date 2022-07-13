using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    [SerializeField] private PlayerManger playerManger;

    public void FixedUpdate()
    {
        var playerPosition = playerManger.Position;
        var enemyPosition = (Vector2)transform.position;
        var direction = playerPosition - enemyPosition;
        direction.Normalize();
        var targetPosition = enemyPosition + direction;
       
        //if (Vector2.Distance(targetPosition,playerPosition) <= 1)
        //{
        //    //Debug.Log("ÓÎÏ·½áÊø Game Over");
        //    return;
        //}
        //rb.DOMove(targetPosition, speed).SetSpeedBased();

    }

}
