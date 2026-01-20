using TMPro;
using UnityEngine;

public class HealthUIText : HealthDisplayBase
{
    [SerializeField] private TextMeshProUGUI _healthText;

    protected override void UpdateHealthDisplay()
    {
        _healthText.text = $"{_stats.Health}/{_stats.MaxHealth}";
    }
}
