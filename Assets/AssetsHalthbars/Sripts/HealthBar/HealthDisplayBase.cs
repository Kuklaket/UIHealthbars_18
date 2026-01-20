using UnityEngine;

public abstract class HealthDisplayBase : MonoBehaviour
{
    [SerializeField] protected HealthSystem _stats;

    protected virtual void OnEnable()
    {
        _stats.HealthChanged += OnHealthChanged;
        OnHealthChanged();
    }

    protected virtual void OnDisable()
    {
        _stats.HealthChanged -= OnHealthChanged;
    }

    protected abstract void OnHealthChanged();
}

