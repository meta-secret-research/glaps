using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MediumPlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 8f;

    private float _currentVelocity;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = new Vector2(_currentVelocity, _rigidbody.velocity.y);
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        // Debug.Log(_currentVelocity);
        _currentVelocity = ctx.ReadValue<float>() * speed;
    }
}
