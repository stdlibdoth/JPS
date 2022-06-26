using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JPSManager : MonoBehaviour
{

    private static JPSManager m_singleton;

    private void Awake()
    {
        if (m_singleton != null)
            DestroyImmediate(this);
        else
        {
            m_singleton = this;
            DontDestroyOnLoad(gameObject);
            Init();
        }
    }



    private void Init()
    {

    }
}