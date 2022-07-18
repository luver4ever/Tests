using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Transformable
{
    public Player(Vector2 position) : base(position) { }

    public void MovePosition(Vector2 delta)
    {
        var nextPosition = Position + delta;

        nextPosition.x = Mathf.Repeat(nextPosition.x, 1);
        nextPosition.y = Mathf.Repeat(nextPosition.y, 1);

        Position = nextPosition;
        Debug.Log(Position);
    }
}
