using UnityEngine;
using System.Collections;

public class InputHandler {
    public KeyCode dashKey;
    public KeyCode jumpKey;
    
    private ICommand dashButton;
    private ICommand jumpButton;
    
	void Start () 
    {
        bindKeys();
	}

    void bindKeys()
    {
        jumpKey = KeyCode.Space;
        dashKey = KeyCode.J;
    }

    public void handleInput()
    {
        //Left move
        //Right move
        //Jump
        if(Input.GetKeyDown(jumpKey))
        {
            Debug.Log("pressed");
            jumpButton.Execute();
        }
        //Charge beam
        //Shoot beam
        //Dash
        else if (Input.GetKeyDown(dashKey))
        {
            dashButton.Execute();
        }
        //Slide
        
    }
	
	void Update () 
    {
        handleInput();
	}
}
