using UnityEngine;
using UnityEngine.UI;

public class HealthUISlider : HealthDisplayBase
{
    [SerializeField] private Slider _slider;

    protected override void OnHealthChanged()
    {
        float healthPercent = (float)_stats.Health / _stats.MaxHealth;
        _slider.value = healthPercent;
    }
}
