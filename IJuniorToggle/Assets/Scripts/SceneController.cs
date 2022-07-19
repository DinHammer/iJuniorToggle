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
        _buttonDealDamage.Init(OnButtonDealDamageClicked);
        _healthBar.Init(_player.MaxHealth);
    }
    
    void Update()
    {
        _currentHealth = _player.Health;
        _healthBar.AddHealth(_currentHealth);
    }

    private void OnButtonHealingClicked()
    {
        _player.Healing();
    }

    private void OnButtonDealDamageClicked()
    {
        _player.DealDamage();
    }
}
