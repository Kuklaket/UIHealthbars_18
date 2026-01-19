using UnityEngine;
using UnityEngine.UI;

public class HealthUISlider : MonoBehaviour
{
    [SerializeField] private Stats _stats;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _stats.HealthChanged += UpdateHealthBar;
    }

    private void OnDisable()
    {
        _stats.HealthChanged -= UpdateHealthBar;
    }

    private void UpdateHealthBar()
    {
        float healthPercent = (float)_stats.Health / _stats.MaxHealth;

        _slider.value = healthPercent;
    }
}
