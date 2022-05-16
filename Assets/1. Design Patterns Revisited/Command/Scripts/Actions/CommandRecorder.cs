using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandRecorder : MonoBehaviour
{
    private readonly Stack<Command> _commands = new Stack<Command>();

    public void Record(Command command) {
        _commands.Push(command);
        command.Execute();
    }

    public void Undo() {
        if (_commands.Count != 0) {
            Command command = _commands.Count != 0 ? _commands.Pop() : null;
            command.Undo();    
        }
    }
}