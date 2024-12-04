using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker _invoker;
    private bool _isReplaying;
    private bool _isRecording;
    private Target _retical;
    private Command _buttonA; 
    private Command _buttonB; 
    private Command _buttonC; 
    private Command _buttonD; 
    private Command _buttonE; 
    
    void Start()
    {
        _invoker = FindObjectOfType<Invoker>();
        _retical = FindObjectOfType<Target>();
        _buttonA = new MoveUp(_retical);
        _buttonB = new MoveDown(_retical);
        _buttonC = new MoveLeft(_retical);
        _buttonD = new MoveRight(_retical);
        _buttonE = new Shoot(_retical);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            _invoker.ExecuteCommand(_buttonA);
        if (Input.GetKeyDown(KeyCode.A))
            _invoker.ExecuteCommand(_buttonC);
        if (Input.GetKeyDown(KeyCode.S))
            _invoker.ExecuteCommand(_buttonB);
        if (Input.GetKeyDown(KeyCode.D))
            _invoker.ExecuteCommand(_buttonD);
        if (Input.GetKeyDown(KeyCode.Space))
            _invoker.ExecuteCommand(_buttonE);
    }
}
