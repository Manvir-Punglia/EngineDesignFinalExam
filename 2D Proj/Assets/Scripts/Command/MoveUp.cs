using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : Command
{
    public Target _target;
    
    public MoveUp(Target tar)
    {
       _target = tar;
    }
    public override void Execute()
    {
        _target.MoveUp();
    }
    public override void Reverse()
    {
        _target.MoveDown();
    }
    
}
