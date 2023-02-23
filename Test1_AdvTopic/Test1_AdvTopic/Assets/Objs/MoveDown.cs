using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : CommandScript
{
    public MoveDown(Transform target) : base(target)
    {

    }

    override public void Execute()
    {
        moved.Translate(Vector3.down);
    }

    override public void Undo()
    {
        moved.Translate(Vector3.up);
    }
}

