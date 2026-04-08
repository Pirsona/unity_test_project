using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScaleAndMove : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotate;
    [SerializeField] private Vector3 _rotateDirection;
    [SerializeField] private float _speedScale;
    [SerializeField] private Vector3 _scaleDirection;

    // Update is called once per frame
    void Update()
    {
        var scale = transform.localScale + _scaleDirection * _speedScale * Time.deltaTime;

        transform.position += transform.forward * _speedMove * Time.deltaTime;
        transform.RotateAround(transform.position, _rotateDirection, _speedRotate * Time.deltaTime);
        transform.localScale = scale;
    }
}
