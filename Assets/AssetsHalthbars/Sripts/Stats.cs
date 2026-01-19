using System;
using System.Collections;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _attack;
    [SerializeField] private int _cooldown;
    [SerializeField] private int _maxHealth = 100;

    private bool _canAttack = true;

    public int Health { get => _health; private set => _health = Mathf.Clamp(value, 0, _maxHealth); }
    public int Attack { get => _attack; private set => _attack = value; }
    public int Cooldown { get => _cooldown; private set => _cooldown = value; }
    public bool CanAttack { get => _canAttack; private set => _canAttack = value; }
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

    public void StartAttackCooldown()
    {
        StartCoroutine(AttackCooldownRoutine());
    }

    private IEnumerator AttackCooldownRoutine()
    {
        CanAttack = false;
        yield return new WaitForSeconds(_cooldown);
        CanAttack = true;
    }
}
