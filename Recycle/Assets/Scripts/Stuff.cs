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
    private bool _isOnFloor;
    public bool IsOnFloor
    {
        get
        {
            return _isOnFloor;
        }
    }


    private void Start()
    {
        _isColliding = false;
        _isOnFloor = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "recycle bin")
        {
            _isColliding = true;
            _isOnFloor = false;
        }
        else
        {
            _isColliding = false;
            _isOnFloor = true;
        }
    }
}
