using System;
using UnityEngine;

public class CounterInput : MonoBehaviour
{
    private const int ClickButton = 0;

    public event Action OnClicked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(ClickButton))
            OnClicked?.Invoke();
    }
}