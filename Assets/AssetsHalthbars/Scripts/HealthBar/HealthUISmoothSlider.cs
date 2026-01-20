using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthUISmoothSlider : HealthDisplayBase
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed = 20f;

    private float _targetThreshold = 0.01f;
    private float _currentDisplay;
    private Coroutine _coroutine;

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        _slider.minValue = 0;
        _slider.maxValue = _stats.MaxHealth;
    }

    protected override void OnEnable()
    {
        base.OnEnable(); 
        _currentDisplay = _stats.Health;
        _slider.value = _currentDisplay;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        if (_coroutine != null) StopCoroutine(_coroutine);
    }

    protected override void UpdateHealthDisplay()
    {
        if (_coroutine != null) StopCoroutine(_coroutine);
        _coroutine = StartCoroutine(UpdateHealthSmoothly());
    }

    private IEnumerator UpdateHealthSmoothly()
    {
        float target = _stats.Health;

        while (Mathf.Abs(_currentDisplay - target) > _targetThreshold)
        {
            _currentDisplay = Mathf.MoveTowards(_currentDisplay, target, _speed * Time.deltaTime);
            _slider.value = _currentDisplay;

            yield return null;
        }

        _slider.value = target;
        _coroutine = null;
    }
}