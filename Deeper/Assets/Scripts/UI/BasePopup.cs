using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class BasePopup : MonoBehaviour
{
    UnityAction _closeCall;

    void Awake()
    {
        Init();
    }

    void OnEnable()
    {
        Show();    
    }

    public abstract void Init();

    public abstract void Show(UnityAction closeCall = null);

    public virtual void Close()
    {
        if (_closeCall != null)
            _closeCall.Invoke();
    }

    public virtual void Back()
    {

    }
}

public class ResultPopup : BasePopup
{
    public override void Back()
    {
        throw new System.NotImplementedException();
    }

    public override void Close()
    {
        throw new System.NotImplementedException();
    }

    public override void Init()
    {
        throw new System.NotImplementedException();
    }

    public override void Show(UnityAction closeCall = null)
    {
        throw new System.NotImplementedException();
    }
}
