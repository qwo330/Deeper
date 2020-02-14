using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float UpPower;

    [SerializeField]
    float DropPower;

    [SerializeField]
    float moveSpeed;

    GameManager gameManager;
    Rigidbody2D rg;

    void Awake()
    {
        Init();    
    }

    void Update()
    {
        if (gameManager.gameState == GameState.Play)
        {

            rg.AddForce(Vector2.down * DropPower * Time.deltaTime, ForceMode2D.Impulse);
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

#if UNITY_EDITOR
            if (Input.GetMouseButtonDown(0))
            {
                TouchScreenAction();
            }
#else
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                TouchScreenAction();
            }
#endif
        }
    }

    public void Init()
    {
        gameManager = GameManager.Instance;
        rg = GetComponentInChildren<Rigidbody2D>();
    }

    public void TouchScreenAction()
    {
        AddForce();
    }

    public void AddForce()
    {
        rg.velocity = Vector2.up * UpPower;
    }
}
