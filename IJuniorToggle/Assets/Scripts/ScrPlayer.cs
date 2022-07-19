using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    [SerializeField] private BaseButton _btnHealsing;
    [SerializeField] private BaseButton _btnDamaging;
    [SerializeField] private ScrHealthBar _healthBar;

    [SerializeField] private int _maxHealthValue;
    [SerializeField] private int _healthValue;
    [SerializeField] private int _damageValue;

    private void Awake()
    {
        _healthBar.Init(_maxHealthValue);
        _btnHealsing.Init(OnBtnHealsingClicked);
        _btnDamaging.Init(OnBtnDamagingClicked);
    }

    private void OnBtnHealsingClicked()
    {
        _healthBar.AddHealth(_healthValue);
    }

    private void OnBtnDamagingClicked()
    {
        _healthBar.AddHealth(-_damageValue);
    }

    
}
