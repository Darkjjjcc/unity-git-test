using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Timers;
using UnityEngine.Events;

public class MagicMissile : MonoBehaviour
{
    [SerializeField] private MissileCreator creator;
    [SerializeField] private UnityEvent missileLanuch;

    private void LaunchMissile()
    {
        creator.CreateMissile();
        missileLanuch.Invoke();
    }

    private void Awake()
    {
        TimersManager.SetLoopableTimer(this, 1, LaunchMissile);
    }
}
