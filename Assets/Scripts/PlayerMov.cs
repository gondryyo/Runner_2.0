using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [SerializeField] private float speed;
    private PlayerInputActions playerInputActions;
    private Rigidbody2D rb;
    

     private void Awake()
    {

        playerInputActions = new PlayerInputActions();
        rb = GetComponent<Rigidbody2D>();

    }

    void Start()
    {
        playerInputActions.Enable();
    }

    private void FixedUpdate()
    {
        Move();

    }

    private void Move()
    {
        Vector3 direction = new Vector3(playerInputActions.Standard.Movement.ReadValue<Vector2>().x, playerInputActions.Standard.Movement.ReadValue<Vector2>().y, 0).normalized;
        rb.AddForce(direction * speed);

    }

    void Update()
    {
        
    }
}
