using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateDirection;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.RotateAround(transform.position, _rotateDirection, _speed * Time.deltaTime);
    }
}
