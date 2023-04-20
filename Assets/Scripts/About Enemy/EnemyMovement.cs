using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    
    private void FixedUpdate()
    {
        var playerPosition = PlayerManager.Position;
        var position = (Vector2)transform.position;
        
        var direction = playerPosition - position;
        direction.Normalize();
        var targetPosition = position + direction;
        
        rb.DOMove(targetPosition, speed).SetSpeedBased();
    }
}
