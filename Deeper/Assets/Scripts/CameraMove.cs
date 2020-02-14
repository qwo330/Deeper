using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    Vector2 offset;

    [SerializeField]
    Transform target;

    public void Init()
    {
        target = GameManager.Instance.Player.transform;
    }

    void FixedUpdate()
    {
        transform.position = target.position + offset.GetVector3();
    }
}
