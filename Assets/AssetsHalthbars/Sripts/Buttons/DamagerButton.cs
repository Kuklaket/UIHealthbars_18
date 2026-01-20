public class DamagerButton : HealthChange
{
    protected override void OnButtonClick()
    {
        _playerStats.GetDamage(_value);
    }
}