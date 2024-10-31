using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float initialSpeed = 5;
    [SerializeField] private float currentSpeed;
    [SerializeField] private float runningTime;
    private bool isRunning = false;
    private Vector2 direction;
    private Rigidbody2D _rigidbody2D;
    private void Awake()
    {
        _rigidbody2D = _rigidbody2D.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = initialSpeed;
    }
    // Update is called once per frame
    void Update()
    {
     
       _rigidbody2D.AddForce(direction);
      
    }
    public void ReadMovement(InputAction.CallbackContext context)
    {
       
    }
}
