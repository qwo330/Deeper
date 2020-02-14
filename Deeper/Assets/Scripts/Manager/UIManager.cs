using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static UIManager instance;
    public static UIManager Instance
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

    [SerializeField]
    Text waterLevelText;

    [SerializeField]
    Text timerText;

    [SerializeField]
    Image filledHP;

    GameManager gameManager;

    void Awake()
    {
        gameManager = GameManager.Instance;    
    }

    public void Init()
    {
        waterLevelText.text = "0";
        timerText.text = "0";
        filledHP.fillAmount = 1;
    }

    void Update()
    {
        UpdateWaterLevel();
        UpdateHP();
        UpdateTimer();
    }

    public void UpdateWaterLevel()
    {

    }

    public void UpdateTimer()
    {

    }

    public void UpdateHP()
    {

    }

    #region OnClickButton
    public void OnClickPause()
    {
        gameManager.SetGamaState(GameState.Pause);
    }
    #endregion
}
