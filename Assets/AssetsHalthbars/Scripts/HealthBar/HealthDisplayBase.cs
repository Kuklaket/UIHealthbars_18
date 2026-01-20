using UnityEngine;

public abstract class HealthDisplayBase : MonoBehaviour
{
    [SerializeField] protected HealthSystem _stats;

    protected virtual void OnEnable()
    {
        _stats.HealthChanged += UpdateHealthDisplay;
        UpdateHealthDisplay();
    }

    protected virtual void OnDisable()
    {
        _stats.HealthChanged -= UpdateHealthDisplay;
    }

    protected abstract void UpdateHealthDisplay();
}

