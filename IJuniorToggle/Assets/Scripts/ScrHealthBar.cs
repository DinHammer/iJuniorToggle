using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class ScrHealthBar : MonoBehaviour
{
    [SerializeField] private float recoveryRate;
    
    private Slider _slider;
    private float _currentValue;
    private float _myValue;
    private float _maxValue;

    private void Update()
    {
        _currentValue = Mathf.MoveTowards(_currentValue, _myValue, recoveryRate * Time.deltaTime);
        _slider.value = _currentValue;
    }

    public void Init(int maxValue)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = maxValue;
        _slider.value = maxValue;
        _maxValue = maxValue;
        _currentValue = maxValue;
        _myValue = maxValue;
    }

    public void AddHealth(int value)
    {
        float nextValue = _myValue + value;
        
        if (0 <= nextValue && nextValue <=_maxValue)
        {
            _myValue += value;
        }
    }

}
