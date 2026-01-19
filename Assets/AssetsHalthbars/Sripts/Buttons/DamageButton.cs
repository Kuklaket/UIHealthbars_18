using UnityEngine;
using UnityEngine.UI;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Stats _playerStats;
    [SerializeField] private int _damage = 10;

    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(DoDamage);
    }

    public void DoDamage()
    {
        if (_playerStats != null)
        {
            _playerStats.GetDamage(_damage);
        }
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(DoDamage);
    }
}
