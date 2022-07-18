using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable
{
    void MovePosition(Vector2 delta, Vector2 position);
}
