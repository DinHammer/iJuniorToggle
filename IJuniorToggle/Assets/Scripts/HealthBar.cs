using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private int _speed;
    
    private Slider _slider;
    private float _currentValue;
    private Coroutine _coroutine;
    private bool _isCoroutineRun;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _currentValue = _slider.value;
    }
    
    public void SetValue(int value)
    {
        if (_isCoroutineRun == true)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(ChangeValue(value));
    }

    private IEnumerator ChangeValue(float value)
    {
        _isCoroutineRun = true;

        while (_currentValue != value)
        {
            _currentValue = Mathf.MoveTowards(_currentValue, value, _speed * Time.deltaTime);
            _slider.value = _currentValue;
            yield return null;
        }

        _isCoroutineRun = false;
    }

}
