public class HealerButton : HealthChanger
{
    protected override void ExecuteHealthChange()
    {
        _healthSystem.AddHealth(_value);
    }
}