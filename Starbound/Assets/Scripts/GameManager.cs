using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance = null;

    public static GameManager Instance
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

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DestroyGameManager()
    {
        Destroy(gameObject);
        instance = null;
    }
}
