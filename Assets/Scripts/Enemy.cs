using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _direction;
    
    public void SetDirection(Vector3 direction)
    {
        _direction = direction.normalized;
    }
    
    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);
    }
}
