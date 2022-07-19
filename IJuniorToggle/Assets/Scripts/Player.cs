using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealthValue;
    [SerializeField] private int _healthValue;
    [SerializeField] private int _damageValue;
    [SerializeField] private float _speedHealthChange;

    private float _newValue;
    
    public float Health { get; private set; }
    public float MaxHealth => _maxHealthValue;
    

    private void Awake()
    {
        Health = _maxHealthValue;
        _newValue = _maxHealthValue;
    }

    private void Update()
    {
        Health = Mathf.MoveTowards(Health, _newValue, _speedHealthChange * Time.deltaTime);
    }

    public void Healing()
    {
        _newValue = Mathf.Clamp(Health + _healthValue, 0, _maxHealthValue);
    }

    public void DealDamage()
    {
        _newValue = Mathf.Clamp(Health - _damageValue, 0, _maxHealthValue);
    }
    
}
