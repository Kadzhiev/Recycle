using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuff : MonoBehaviour
{
    private bool _isColliding;
    public bool IsColliding
    {
        get
        {
            return _isColliding;
        }
    }
    private float _speed;
    public float Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            _speed = value;
        }
    }
    private Transform _transform;

    private void Start()
    {
        _isColliding = false;
        _transform = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Transporter")
        {
            _isColliding = true;
        }
        else
        {
            _isColliding = false;
        }
    }
    private void Update()
    {
        Debug.Log(_speed);
        _transform.position += Vector3.forward * _speed * Time.deltaTime;
    }
}
