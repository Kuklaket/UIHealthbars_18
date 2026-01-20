public class HealerButton : HealthChange
{
    protected override void OnButtonClick()
    {
        _playerStats.AddHealth(_value);
    }
}