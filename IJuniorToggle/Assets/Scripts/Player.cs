using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealthValue;
    [SerializeField] private int _healthValue;
    [SerializeField] private int _damageValue;
    
    private float _health;
    public float MaxHealth => _maxHealthValue;
    
    private void Awake()
    {
        _health = _maxHealthValue;
    }

    public float Heal()
    {
        _health = Mathf.Clamp(_health + _healthValue, 0, _maxHealthValue);
        return _health;
    }

    public float TakeDamage()
    {
        _health = Mathf.Clamp(_health - _damageValue, 0, _maxHealthValue);
        return _health;
    }
    
}
