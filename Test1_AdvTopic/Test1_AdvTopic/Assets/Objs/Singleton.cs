using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;


public class Singleton : MonoBehaviour
{
    private static Stack<commandInterface> _CommandBuffer = new Stack<commandInterface>();
    private static Stack<commandInterface> _UndoBuffer = new Stack<commandInterface>();


    public static Singleton Instance { get; private set; }


    private void Awake()
    {
        //Destroy if this isnt the first instance
        if (Instance != null && Instance != this)
        {
            Destroy(this);

        }

        else
        {
            Instance = this;
        }

  
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddMove(commandInterface command)
    {
        command.Execute();
        _CommandBuffer.Push(command);
        _UndoBuffer.Push(command);
    }

    public void UndoMove()
    {
        if (_CommandBuffer.Count != 0)
        {
            commandInterface c = _CommandBuffer.Pop();
            c.Undo();
            _UndoBuffer.Push(c);
        }
    }


}
