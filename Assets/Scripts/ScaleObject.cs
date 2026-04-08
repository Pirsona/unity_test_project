using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _moveDirection;

    void Update()
    {
        var scale = transform.localScale + _moveDirection * _speed * Time.deltaTime;

        transform.localScale = scale;
    }
}
