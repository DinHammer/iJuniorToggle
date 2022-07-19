using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class HealthBar : MonoBehaviour
{
    private Slider _slider;

    public void Init(float maxValue)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = maxValue;
        _slider.value = maxValue;
    }

    public void AddHealth(float value)
    {
        _slider.value = value;
    }

}
