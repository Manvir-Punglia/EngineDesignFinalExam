using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : Command
{
    public Target _target;
    
    public MoveRight(Target tar)
    {
        _target = tar;
    }
    public override void Execute()
    {
        _target.MoveRight();
    }
    public override void Reverse()
    {
        _target.MoveLeft();
    }
    
}

