using UnityEngine;
using UnityEngine.UI;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Stats _playerStats;
    [SerializeField] private int _heal = 10;

    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(DoHeal);
    }

    public void DoHeal()
    {
        _playerStats.AddHealth(_heal);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(DoHeal);
    }
}
