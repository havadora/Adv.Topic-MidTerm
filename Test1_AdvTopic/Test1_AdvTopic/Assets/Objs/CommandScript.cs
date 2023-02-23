using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public interface commandInterface
    {
        void Execute();
        void Undo();
    }

    public abstract class CommandScript : commandInterface
    {
        protected Transform moved;

        public CommandScript(Transform target)
        {
            moved = target;
        }

        public virtual void Execute()
        {
          
        }

        public virtual void Undo()
        {

        }
    }


