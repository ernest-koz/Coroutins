using UnityEngine;

public class CounterInput : MonoBehaviour
{
    [SerializeField] private CounterService _counterService;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _counterService.Toggle();
        }
    }
}