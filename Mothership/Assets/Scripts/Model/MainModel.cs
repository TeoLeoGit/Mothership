using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainModel", menuName = "Model/MainModel", order = 0)]
public class MainModel : ScriptableObject
{
    //Events
    public event Action OnSomething;


    private string _hellBoy;

    public void CallSomethingFromModel()
    {
        Debug.Log("sdfsdfs");
    }
}
  
