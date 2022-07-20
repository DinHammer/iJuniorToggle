using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private BaseButton _buttonHealing;
    [SerializeField] private BaseButton _buttonDealDamage;

    private Player _player;
    private float _currentHealth;
    
    private void Awake()
    {
        _buttonHealing.Init(OnButtonHealingClicked);
        _buttonDealDamage.Init(OnButtonTakeDamageClicked);
        _player = GetComponent<Player>();
    }

    private void OnButtonHealingClicked()
    {
        _player.Heal();
    }

    private void OnButtonTakeDamageClicked()
    {
        _player.TakeDamage();
    }
}
