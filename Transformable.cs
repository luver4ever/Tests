using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Transformable
{
    public virtual Vector2 Position { get; protected set; }

    public Transformable(Vector2 position)
    {
        Position = position;
    }
}
