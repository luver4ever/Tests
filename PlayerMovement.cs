using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    private readonly Player _player;
    
    public PlayerMovement(Player player)
    {
        _player = player;
    }

    public void Move(Vector2 delta, float repeatValue = 1)
    {
        _player.MovePosition(delta, repeatValue);
    }
    
}
