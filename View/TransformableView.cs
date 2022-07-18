using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformableView : MonoBehaviour
{
    /// <summary>
    /// Класс отвечающий за отображение объекта в unity
    /// </summary>
    private Camera _camera;
    private Transformable _model;

    public void Init(Camera camera, Transformable transformable)
    {
        //Замена конструктору для вызова в CompositeRoot
        _camera = camera;
        _model = transformable;
    }

    private void LateUpdate()
    {
        transform.position = _camera.ViewportToWorldPoint(GetCurrentPosition());
    }

    private Vector3 GetCurrentPosition()
    {
        return new Vector3(_model.Position.x, _model.Position.y, 1);
    }
}
