using TMPro;
using UnityEngine;

public class Text : HealthDisplayBase
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void UpdateHealthDisplay()
    {
        _text.text = $"{_healthSystem.Value}/{_healthSystem.MaxValue}";
    }
}
