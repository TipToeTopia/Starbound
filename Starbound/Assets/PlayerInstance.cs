using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstance : MonoBehaviour
{
    private static PlayerInstance instance = null;

    public const string PLAYER_TAG = "Player";

    public static PlayerInstance Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance)
        {
            DestroyImmediate(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);

    }

    public void DestroyGameManager()
    {
        Destroy(gameObject);
        instance = null;
    }
}
