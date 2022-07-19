using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private BaseButton _buttonHealing;
    [SerializeField] private BaseButton _buttonDealDamage;
    [SerializeField] private Player _player;
    [SerializeField] private HealthBar _healthBar;

    private float _currentHealth;
    private void Awake()
    {
        _buttonHealing.Init(OnButtonHealingClicked);
        _buttonDealDamage.Init(OnButtonTakeDamageClicked);
        _healthBar.Init(_player.MaxHealth);
    }

    private void OnButtonHealingClicked()
    {
        _currentHealth = _player.Heal();
        _healthBar.SetValue(_currentHealth);
    }

    private void OnButtonTakeDamageClicked()
    {
        _currentHealth = _player.TakeDamage();
        _healthBar.SetValue(_currentHealth);
    }
}
