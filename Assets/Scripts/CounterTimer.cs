using System;
using System.Collections;
using UnityEngine;

public class CounterTimer: MonoBehaviour
{
    [SerializeField] private CounterInput _input;

    private const float StepDelaySeconds = 0.5f;

    public event Action<int> OnValueChanged;

    private int _value;
    private Coroutine _coroutine;
    private WaitForSeconds _stepDelay;

    private void Awake()
    {
        _stepDelay = new WaitForSeconds(StepDelaySeconds);
    }

    private void OnEnable()
    {
        _input.OnClicked += HandleClick;
    }

    private void OnDisable()
    {
        _input.OnClicked -= HandleClick;
    }

    private void HandleClick()
    {
        if (_coroutine == null)
            _coroutine = StartCoroutine(Count());
        else
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    private IEnumerator Count()
    {
        while (true)
        {
            yield return _stepDelay;

            _value++;
            OnValueChanged?.Invoke(_value);
            Debug.Log($"Counter: {_value}");
        }
    }
}