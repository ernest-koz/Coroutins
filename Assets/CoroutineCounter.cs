using System.Collections;
using UnityEngine;
using TMPro;

public class CoroutineCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterText;

    private int _count = 0;
    private bool _running = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!_running)
            {
                _running = true;
                StartCoroutine(CounterRoutine());
            }
            else
            {
                _running = false;
            }
        }
    }

    private IEnumerator CounterRoutine()
    {
        while (_running)
        {
            yield return new WaitForSeconds(0.5f);
            _count++;
            _counterText.text = _count.ToString();
            Debug.Log("Counter: " + _count);
        }
    }
}
