using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void Show(int value)
    {
        _text.text = value.ToString();
    }
}
