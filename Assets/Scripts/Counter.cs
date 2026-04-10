using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textCount;
    [SerializeField] private float _timeStep;

    private int _currentCount;
    private bool _isCounting = false;
    private WaitForSeconds _wait;
    private Coroutine _coroutine;

    private void Start()
    {
        _wait = new WaitForSeconds(_timeStep);
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (_isCounting == false)
            {
                _isCounting = true;
                _coroutine = StartCoroutine(CountNumber());
                Debug.Log("Корутина запущена!");
            }
            else
            {
                _isCounting = false;
                StopCoroutine(_coroutine);
                Debug.Log("Корутина остановлена!");
            }
        }
    }

    private IEnumerator CountNumber()
    {
        while (_isCounting)
        {
            yield return _wait;
            _currentCount++;
            _textCount.text = _currentCount.ToString();
        }
    }
}
