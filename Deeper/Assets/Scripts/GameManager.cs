using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SubMarine Player;

    [SerializeField]
    CameraMove cameraMove;

    static GameManager instance;
    public static GameManager Instance
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

    public void Init()
    {

    }

    public float GetDeep()
    {
        float deep = Mathf.Abs(Player.transform.position.y);
        return deep;
    }
}
