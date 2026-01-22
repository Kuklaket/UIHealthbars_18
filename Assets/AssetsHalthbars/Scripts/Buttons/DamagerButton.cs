public class DamagerButton : HealthChanger
{
    protected override void ExecuteHealthChange()
    {
        _healthSystem.GetDamage(_value);
    }
}