using TMPro;
using UnityEngine;

public class HealthUIText : MonoBehaviour
{
    [SerializeField] private Stats _playerStats;
    [SerializeField] private TextMeshProUGUI _healthText;

    private void OnEnable()
    {
        _playerStats.HealthChanged += UpdateHealthText;
        UpdateHealthText();
    }

    private void OnDisable()
    {
        _playerStats.HealthChanged -= UpdateHealthText;
    }

    private void UpdateHealthText()
    {
            _healthText.text = $"{_playerStats.Health}/{_playerStats.MaxHealth}";        
    }
}
