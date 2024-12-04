using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : Command

{
    public Target _target;

    public MoveDown(Target tar)
    {
        _target = tar;
    }

    public override void Execute()
    {
        _target.MoveDown();
    }
    public override void Reverse()
    {
        _target.MoveUp();
    }
}