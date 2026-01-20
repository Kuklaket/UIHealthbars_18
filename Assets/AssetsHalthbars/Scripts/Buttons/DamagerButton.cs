public class DamagerButton : HealthChange
{
    protected override void ExecuteHealthChange()
    {
        _playerStats.GetDamage(_value);
    }
}