using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput
{
    private PlayerMovement _movement;

    public PlayerInput(PlayerMovement movement)
    {
        _movement = movement;
    }

    public void Update(float deltaTime, float repeatValue = 1)
    {
        var delta = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        _movement.Move(delta * deltaTime, repeatValue);
    }
}
