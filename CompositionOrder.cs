using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositionOrder : MonoBehaviour
{
    [SerializeField] private List<CompositeRoot> _compositionOrder;

    /// <summary>
    /// Класс, отвечающий за включение всех CompositeRoot. Благодаря нему происходит инициализация(конструирование) всех объектов внутри compositeRoot 
    /// </summary>
    private void Awake()
    {
        foreach(var composite in _compositionOrder)
        {
            composite.Compose();
            composite.enabled = true;
        }
    }
}
