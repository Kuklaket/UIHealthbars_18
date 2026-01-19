using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthUISmoothSlider : MonoBehaviour
{
    [SerializeField] private Stats _stats;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed = 15f;

    private float _currentDisplay;
    private Coroutine _coroutine;

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        _slider.minValue = 0;
        _slider.maxValue = _stats.MaxHealth;
    }

    private void OnEnable()
    {
        _currentDisplay = _stats.Health;
        _slider.value = _currentDisplay;
        _stats.HealthChanged += UpdateHealth;
    }

    private void OnDisable()
    {
        _stats.HealthChanged -= UpdateHealth;
        if (_coroutine != null) StopCoroutine(_coroutine);
    }

    private void UpdateHealth()
    {
        if (_coroutine != null) StopCoroutine(_coroutine);
        _coroutine = StartCoroutine(UpdateHealthSmoothly());
    }

    private IEnumerator UpdateHealthSmoothly()
    {
        float target = _stats.Health;

        while (Mathf.Abs(_currentDisplay - target) > 0.01f)
        {
            _currentDisplay = Mathf.MoveTowards(_currentDisplay, target, _speed * Time.deltaTime);
            _slider.value = _currentDisplay;
            yield return null;
        }

        _slider.value = target;
        _coroutine = null;
    }
}