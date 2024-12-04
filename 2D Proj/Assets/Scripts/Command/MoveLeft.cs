using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Command
{
    public Target _target;
    
    public MoveLeft(Target tar)
    {
        _target = tar;
    }
    public override void Execute()
    {
        _target.MoveLeft();
    }
    public override void Reverse()
    {
        _target.MoveRight();
    }
    
}
