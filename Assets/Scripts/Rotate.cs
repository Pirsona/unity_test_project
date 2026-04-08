using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateDirection;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.RotateAround(transform.position, _rotateDirection, _speed * Time.deltaTime);
    }
}
