using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Death : MonoBehaviour
{
    [SerializeField] private UnityEvent died;
    
    public void CheckDeath(int health)
    {
        if (health <= 0)
            Die();
    }


    private void Die()
    {
        Destroy(gameObject);
        
        died.Invoke();
    }
}
