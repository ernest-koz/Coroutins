using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private CounterTimer _counter;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _counter.OnValueChanged += Show;
    }

    private void OnDisable()
    {
        _counter.OnValueChanged -= Show;
    }

    private void Show(int value)
    {
        _text.text = value.ToString();
    }
}