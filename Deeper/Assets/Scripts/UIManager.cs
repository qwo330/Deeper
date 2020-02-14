using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public UIManager Instance
    {
        get
        {
            return instance;
        }
        set
        {
            instance = value;
        }
    }
}
