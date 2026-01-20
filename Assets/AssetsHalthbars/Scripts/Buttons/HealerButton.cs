public class HealerButton : HealthChange
{
    protected override void ExecuteHealthChange()
    {
        _playerStats.AddHealth(_value);
    }
}