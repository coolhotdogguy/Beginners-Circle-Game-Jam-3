﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempCoagDontDestroy : MonoBehaviour
{
    void Start()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
