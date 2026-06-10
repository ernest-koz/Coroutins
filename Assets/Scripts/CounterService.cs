using System.Collections;
using UnityEngine;

public class CounterService : MonoBehaviour
{
    [SerializeField] private CounterView _view;

    private int _value = 0;
    private bool _isRunning = false;

    private void Start()
    {
        _view.Show(_value);
    }

    public void Toggle()
    {
        if (_isRunning == false)
        {
            _isRunning = true;
            StartCoroutine(Count());
        }
        else
        {
            _isRunning = false;
        }
    }

    private IEnumerator Count()
    {
        while (_isRunning)
        {
            yield return new WaitForSeconds(0.5f);
            _value++;
            _view.Show(_value);
            Debug.Log(_value);
        }
    }
}