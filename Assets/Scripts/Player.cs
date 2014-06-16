using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    InputHandler inputHandler;
    static Player instance = null;

    public static Player Instance()
    {
        if (instance != null)
        {
            return instance;
        }
        else
        {
            return null;
            //Error
        }
    }

	void Start () 
    {
        instance = this;
        inputHandler = new InputHandler();
	}
	
	void Update ()
    {
        
	}
}
