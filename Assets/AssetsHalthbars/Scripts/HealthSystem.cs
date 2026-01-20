using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _maxHealth = 100;

    public int Health { get => _health; private set => _health = Mathf.Clamp(value, 0, _maxHealth); }

    public int MaxHealth => _maxHealth;

    public event Action Died;
    public event Action HealthChanged;

    public void GetDamage(int damageCount)
    {
        Health -= damageCount;

        HealthChanged?.Invoke();

        if (Health <= 0)
            Died?.Invoke();
    }

    public void AddHealth(int healthCount)
    {
        Health += healthCount;

        HealthChanged?.Invoke();
    }
}
