using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _moveDirection;

    private void Update()
    {
        var scale = transform.localScale + _moveDirection * _speed * Time.deltaTime;

        transform.localScale = scale;
    }
}
