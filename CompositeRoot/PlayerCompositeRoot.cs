using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCompositeRoot : CompositeRoot
{
    //Объекты, что принадлежат Unity
    [SerializeField] private TransformableView _transformableView;
    [SerializeField] private Camera _camera;
    //Debug thing for test what do lenght param in Mathf.Repeat
    [SerializeField] [Range(1, 10)]private float _repeatValue = 1;
    //Классы, что не наследуются от MonoBehaviour
    private Player _player;
    private PlayerMovement _movement;
    private PlayerInput _input;

    public override void Compose()
    {
        //Собственно Конструкторы классов
        _player = new Player(new Vector2(0, 0));
        _movement = new PlayerMovement(_player);
        _input = new PlayerInput(_movement);
        //Инициализация View
        _transformableView.Init(_camera, _player);
    }

    private void Update()
    {
        //Работа Update в классе input
        _input.Update(Time.deltaTime, _repeatValue);
    }
}
