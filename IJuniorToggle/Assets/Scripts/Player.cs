using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealthValue;
    [SerializeField] private int _healingValue;
    [SerializeField] private int _damagingValue;

    private int _currentHealth;
    
    public UnityEvent<int> unityEvent;

    private void Awake()
    {
        _currentHealth = _maxHealthValue;
    }

    public void Heal()
    {
        _currentHealth = Mathf.Clamp(_currentHealth + _healingValue, 0, _maxHealthValue);
        unityEvent.Invoke(_currentHealth);
    }

    public void TakeDamage()
    {
        _currentHealth = Mathf.Clamp(_currentHealth - _damagingValue, 0, _maxHealthValue);
        unityEvent.Invoke(_currentHealth);
    }
    
}
