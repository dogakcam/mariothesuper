﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class possesion : MonoBehaviour
{
    
    public IPossessable controlledObject;
 
    public void Possess(IPossessable obj)
    {
        if(obj != null)
        {
            // unpossess the current object
            if(controlledObject != null)
            {
                controlledObject.UnPossess();
            }
            // possess the new object
            controlledObject = obj;
            controlledObject.Possess();
        }
    }
 
    public void UnPossess()
    {
        // unpossess the current object
        if(controlledObject != null)
        {
            controlledObject.UnPossess();
        }
    }
    public interface IPossessable
    {
        void Possess();
        void UnPossess();
    }
}
