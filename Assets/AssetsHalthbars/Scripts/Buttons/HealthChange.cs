using UnityEngine;
using UnityEngine.UI;

public abstract class HealthChange : MonoBehaviour
{
    [SerializeField] protected HealthSystem _playerStats;
    [SerializeField] protected int _value = 10;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ExecuteHealthChange);
    }

    private void OnDisable()
    {
        if (_button != null)
        {
            _button.onClick.RemoveListener(ExecuteHealthChange);
        }
    }

    protected abstract void ExecuteHealthChange();
}
