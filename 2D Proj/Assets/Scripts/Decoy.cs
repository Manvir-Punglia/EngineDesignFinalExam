using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Decoy : MonoBehaviour
{
    public Rigidbody2D _rb;
    public GameObject _point1;
    public GameObject _point2;
    public float _speed = 2.0f;
    public Vector2 _direction;
    public Transform _goal;
    public bool _goingTo1;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector2 direction = (_point1.gameObject.transform.position - transform.position).normalized;
        _rb.velocity = direction * _speed;
        _goal = _point1.gameObject.transform;
        _goingTo1 = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(_goal.position, this.transform.position) < 1.5f)
        {
            if (_goingTo1)
            {
                Vector2 direction = (_point2.gameObject.transform.position - transform.position).normalized;
                _goal = _point2.gameObject.transform;
                _rb.velocity = direction * _speed;
                _goingTo1 = false;
            }
            else
            {
                Vector2 direction = (_point1.gameObject.transform.position - transform.position).normalized;
                _goal = _point1.gameObject.transform;
                _rb.velocity = direction * _speed;
                _goingTo1 = true;
            }
            
        }
    }
    
    
    


    
}
