using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : Transformable
{
    public Ship(Vector2 position) : base(position)
    {

    }

    public void MovePosition(Vector2 startPoint, Vector2 endPoint, float deltaTime, float moveTime = 2f)
    {
        float duration = 0;

        while (duration < 1)
        {
            Position = Vector2.Lerp(startPoint, endPoint, duration);

            duration += deltaTime / moveTime;
        }

    }
}
