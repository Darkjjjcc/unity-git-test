using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Timers;
using UnityEngine.Events;

public class Attack : MonoBehaviour
{
    [SerializeField] private string targetTag;
    private bool _canAttack = true;
    [SerializeField] private UnityEvent attack;
    [SerializeField] private int damageamount;

    private void OnTriggerEnter2D(Collider2D col)
    {
        DealDamage(col);
    }

    private void CanAttack()
    {
        _canAttack = true;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        DealDamage(other);
    }

    private void DealDamage(Collider2D other)
    {
        if (!_canAttack) return;
        if (other.CompareTag(targetTag))
        {
            var damageable = other.GetComponent<Damageable>();
            damageable.TakeDamage(damageamount);
            TimersManager.SetTimer(this, 1, CanAttack);
            _canAttack = false;
            attack.Invoke();
        }
    }

}
