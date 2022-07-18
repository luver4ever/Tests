using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Transformable
{
    public Player(Vector2 position) : base(position) { }

    public void MovePosition(Vector2 delta, float repeatValue = 1)
    {
        var nextPosition = Position + delta;

        nextPosition.x = Mathf.Repeat(nextPosition.x, repeatValue);
        nextPosition.y = Mathf.Repeat(nextPosition.y, repeatValue);

        Position = nextPosition;
    }
}
