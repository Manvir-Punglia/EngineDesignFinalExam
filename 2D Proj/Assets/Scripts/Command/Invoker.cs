using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class Invoker : MonoBehaviour
{
    
    private List<Command> _recordedCommands = new List<Command>();
    private static Command lastCommand;
    public bool reversed = false;
    
    public void ExecuteCommand(Command command)
    {
        _recordedCommands.Add(command);
        if (reversed == true)
        {
            command.Reverse();
            Debug.Log("command.ToString()");
        }
        else
        {
            command.Execute();
        }
        
        lastCommand = command;
        Debug.Log(lastCommand);
        
        
        Debug.unityLogger.Log(command.ToString());
    }

    public void ReverseLastCommand()
    {
        lastCommand.Reverse();
    }
}
