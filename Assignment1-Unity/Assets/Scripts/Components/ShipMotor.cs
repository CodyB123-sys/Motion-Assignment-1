using UnityEngine;
using System.Collections;

public class ShipMotor : MonoBehaviour
{
    public float AccelerationTime = 1;
    float AccelerationRate;
    public float DecelerationTime = 1;
    float DecelerationRate;
    public float MaxSpeed = 1;
    float speed;

    Vector3 move;

    /// <summary>
    /// Move the ship using it's transform only based on the current input vector. Do not use rigid bodies.
    /// </summary>
    /// <param name="input">The input from the player. The possible range of values for x and y are from -1 to 1.</param>
    /// 

    void Update()
    {
        Vector2 playerInput;
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical");
        HandleMovementInput(playerInput);

        Debug.Log(speed);
    }

    public void HandleMovementInput( Vector2 input )
    {
        AccelerationRate = MaxSpeed / AccelerationTime;
        DecelerationRate = MaxSpeed / DecelerationTime;

        if (input.x != 0 || input.y != 0)
        {
            move.Set(input.x, input.y, 0);
            speed = Mathf.Min(speed + AccelerationRate * Time.deltaTime, MaxSpeed);
        }
        else 
        {
            speed = Mathf.Max(speed - DecelerationRate * Time.deltaTime, 0);
        }

        move = move.normalized * speed * Time.deltaTime;

        transform.Translate(move);
    }
    
}
