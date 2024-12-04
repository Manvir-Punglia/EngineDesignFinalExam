using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : Command
{
    public Target _target;
    
    
    public Shoot(Target tar)
    {
        _target = tar;
    }
    public override void Execute()
    {
        _target.Shoot();
    }
    public override void Reverse()
    {
        
    }
    
}

