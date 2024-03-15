using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MainPresenter", menuName = "Presenter/MainPresenter", order = 0)]
public class MainPresenter : ScriptableObject
{
    [SerializeField] MainModel _mainModel;

    private void OnEnable()
    {
        _mainModel.OnSomething += Something;
        _mainModel.CallSomethingFromModel();
    }

    private void OnDisable()
    {
        _mainModel.OnSomething -= Something;
    }

    void Something()
    {

    }
}
