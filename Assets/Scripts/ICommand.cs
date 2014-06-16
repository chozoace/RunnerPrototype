using UnityEngine;
using System.Collections;

public class ICommand
{
    public ICommand() { }
    public virtual void Execute() { }
};

class JumpCommand : ICommand
{
    public virtual void Execute() { jump(); }

    void jump()
    {
        Debug.Log("Jumping");
    }
}

class DashCommand : ICommand
{
    public virtual void Execute() { dash(); }

    void dash()
    {
        Debug.Log("Dashing");
    }
}