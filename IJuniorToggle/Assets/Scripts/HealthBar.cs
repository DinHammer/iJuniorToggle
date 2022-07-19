using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Slider _slider;
    private float _newValue;
    private float _currentValue;
    

    public void Init(float maxValue)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = maxValue;
        _slider.value = maxValue;
        _currentValue = maxValue;
        _newValue = maxValue;
    }

    private void Update()
    {
        _currentValue = Mathf.MoveTowards(_currentValue, _newValue, _speed * Time.deltaTime);
        _slider.value = _currentValue;
    }

    public void SetValue(float value)
    {
        _newValue = value;
    }

}
