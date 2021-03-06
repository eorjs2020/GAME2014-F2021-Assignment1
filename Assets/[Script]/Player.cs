using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigid;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _jumpForce;

    private float _movement;

    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _movement = Input.GetAxis("Horizontal");
        _rigid.velocity = new Vector2(_movement * _speed, _rigid.velocity.y);
    }
}
