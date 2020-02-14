using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMarine : MonoBehaviour
{
    public int MaxHP;
    public int HP;
    public int Armor; // Regist Water Pressure

    void Update()
    {
        
    }

    public void Init()
    {
        HP = MaxHP;
        Armor = 0;

        transform.position = Vector2.zero;
    }

    public float GetDeep()
    {
        float deep = Mathf.Abs(transform.position.y);
        return deep;
    }

    public void GetDamage()
    {
        float deep = GetDeep();
        int damage = (int)(deep * 0.0001f);
        HP -= damage;

        if (HP <= 0)
        {
            GameManager.GameOverEvent.Invoke();
        }
    }
}
