using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Utility
{
    public static Vector3 GetVector3(this Vector2 vector2, float z = 0)
    {
        return new Vector3(vector2.x, vector2.y, z);
    }

    public static T RandomPick<T>(this List<T> list)
    {
        int count = list.Count;
        int select = Random.Range(0, count - 1);
        T result = list[select];
        return result;
    }

    /// <summary>
    ///  리스트에서 args를 제외한 값 중 랜덤한 값을 반환한다.
    /// </summary>
    /// <param name="args">Except Item</param>
    public static T RandomPick<T>(this List<T> list, params T[] args)
    {
        List<T> newList = new List<T>(list);

        for (int i = 0; i < args.Length; i++)
        {
            if (newList.Contains(args[i]))
                newList.Remove(args[i]);
        }

        return newList.RandomPick();
    }

    #region Debug
    public static void Log(object message)
    {
#if UNITY_EDITOR || DEVELOPER 
        Debug.Log(message);
#endif
    }

    public static void LogWarning(object message)
    {
#if UNITY_EDITOR || DEVELOPER 
        Debug.LogWarning(message);
#endif
    }

    public static void LogError(object message)
    {
#if UNITY_EDITOR || DEVELOPER 
        Debug.LogError(message);
#endif
    }

    public static void LogFormat(object message, params object[] args)
    {
#if UNITY_EDITOR || DEVELOPER 
        Debug.LogFormat(message.ToString(), args);
#endif
    }

    public static void LogWarningFormat(object message, params object[] args)
    {
#if UNITY_EDITOR || DEVELOPER 
        Debug.LogWarningFormat(message.ToString(), args);
#endif
    }

    public static void LogErrorFormat(object message, params object[] args)
    {
#if UNITY_EDITOR || DEVELOPER 
        Debug.LogErrorFormat(message.ToString(), args);
#endif
    }
    #endregion
}

public class Event : UnityEvent { }
public class Event<T> : UnityEvent<T> { }
public class Event<T1, T2> : UnityEvent<T1, T2> { }
public class Event<T1, T2, T3> : UnityEvent<T1, T2, T3> { }
public class Event<T1, T2, T3, T4> : UnityEvent<T1, T2, T3, T4> { }
