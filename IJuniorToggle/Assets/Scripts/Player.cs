using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private BaseButton _btnHealsing;
    [SerializeField] private BaseButton _btnDamaging;
    [SerializeField] private HealthBar _healthBar;

    [SerializeField] private int _maxHealthValue;
    [SerializeField] private int _healthValue;
    [SerializeField] private int _damageValue;
    [SerializeField] private float recoveryRate;
    
    private float _currentValue;
    private int _myValue;

    private void Awake()
    {
        _healthBar.Init(_maxHealthValue);
        _btnHealsing.Init(OnBtnHealsingClicked);
        _btnDamaging.Init(OnBtnDamagingClicked);
        _myValue = _maxHealthValue;
        _currentValue = _maxHealthValue;
    }

    private void Update()
    {
        _currentValue = Mathf.MoveTowards(_currentValue, _myValue, recoveryRate * Time.deltaTime);
        _healthBar.AddHealth(_currentValue);
    }

    private void OnBtnHealsingClicked()
    {
        AddHealthValue(_healthValue);
    }

    private void OnBtnDamagingClicked()
    {
        AddHealthValue(-_damageValue);
    }

    private void AddHealthValue(int value)
    {
        float nextValue = _myValue + value;
        
        if (0 <= nextValue && nextValue <=_maxHealthValue)
        {
            _myValue += value;
        }
    }


}
