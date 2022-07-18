using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CompositeRoot : MonoBehaviour
{
    //CompositeRoot соединяет код из не monoBeh с движком юнити, а метод Compose заменяет стандартные шарповские конструкторы
    public abstract void Compose();
}
