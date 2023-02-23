using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveUp : CommandScript
{
    public MoveUp(Transform target) : base(target)
    {

    }

    override public void Execute()
    {
        moved.Translate(Vector3.up);
    }

    override public void Undo()
    {
        moved.Translate(Vector3.down);
    }
}
