using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Ready,
    Play,
    GameOver,
    Pause,
}

public class GameManager : MonoBehaviour
{
    public static Event GameOverEvent = new Event();

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

    public GameState gameState { get; private set; }

    public SubMarine Player;
    
    [SerializeField]
    CameraMove cameraMove;
    UIManager uIManager;

    void Awake()
    {
        uIManager = UIManager.Instance;    
    }

    public void Init()
    {
        SetGamaState(GameState.Ready);

        uIManager.Init();
        Player.Init();
        cameraMove.Init();
    }

    public void SetGamaState(GameState state)
    {
        gameState = state;
    }

    public float GetDeep()
    {
        float deep = Player.GetDeep();
        return deep;
    }

    public void GameStart()
    {
        SetGamaState(GameState.Play);
    }

    public void GameOver()
    {
        SetGamaState(GameState.GameOver);
    }
}
