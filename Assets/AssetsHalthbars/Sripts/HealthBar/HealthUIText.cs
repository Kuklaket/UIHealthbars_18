using TMPro;
using UnityEngine;

public class HealthUIText : HealthDisplayBase
{
    [SerializeField] private TextMeshProUGUI _healthText;

    protected override void OnHealthChanged()
    {
        _healthText.text = $"{_stats.Health}/{_stats.MaxHealth}";
    }
}
