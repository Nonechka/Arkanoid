using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float _borderPositionx = 8.40f;
    private Transform _transform;
    public float MoveSpeed;
    

    private void Start()
    {
        _transform = GetComponent<Transform>();

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _transform.position += Vector3.left * MoveSpeed * Time.deltaTime ;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _transform.position += Vector3.right * MoveSpeed * Time.deltaTime ;

        }
        if (Input.GetKey(KeyCode.W))
        {
            _transform.position += Vector3.up * MoveSpeed * Time.deltaTime ;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _transform.position += Vector3.down * MoveSpeed * Time.deltaTime ;
        }
        //if(_transform.position.x > _borderPositionx)
        //{
        //    _transform.position = new Vector3(_borderPositionx,_transform.position.y,_transform.position.z);
        //}
        //if(_transform.position.x < -_borderPositionx)
        //{
        //    _transform.position = new Vector3(-_borderPositionx, _transform.position.y, _transform.position.z);
        //}
        float stopZoneX = Mathf.Clamp(_transform.position.x, -_borderPositionx, _borderPositionx);
        _transform.position = new Vector3(stopZoneX, _transform.position.y, _transform.position.z);
    }
}
