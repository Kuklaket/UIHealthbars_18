using UnityEngine;
using UnityEngine.UI;

public class Slider : HealthDisplayBase
{
    [SerializeField] private UnityEngine.UI.Slider _slider;

    protected override void UpdateHealthDisplay()
    {
        float percent = (float)_healthSystem.Value / _healthSystem.MaxValue;
        _slider.value = percent;
    }
}
