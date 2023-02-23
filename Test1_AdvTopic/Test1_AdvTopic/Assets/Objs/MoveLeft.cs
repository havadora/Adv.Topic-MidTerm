using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : CommandScript
{

    public MoveLeft(Transform target) : base(target)
    {

    }

    override public void Execute()
    {
        moved.Translate(Vector3.left);
    }

    override public void Undo()
    {
        moved.Translate(Vector3.right);
    }

}
