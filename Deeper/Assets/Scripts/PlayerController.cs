using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float UpPower;

    [SerializeField]
    float DropPower;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rg;

    void Awake()
    {
        Init();    
    }

    void Update()
    {
        rg.AddForce(Vector2.down * DropPower * Time.deltaTime, ForceMode2D.Impulse);
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            TouchScreen();
        }
#else
        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            TouchScreen();
        }
#endif
    }

    public void Init()
    {
        rg = GetComponentInChildren<Rigidbody2D>();

    }

    public void TouchScreen()
    {
        Debug.Log("touch");
        AddForce();
    }

    public void AddForce()
    {
        rg.velocity = Vector2.up * UpPower;
        //rg.velocity = Vector2.zero;
        //rg.AddForce(Vector2.up * UpPower, ForceMode2D.Impulse);
        //rg.AddForce(Vector2.up * UpPower);
    }
}
