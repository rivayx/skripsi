﻿using UnityEngine.SceneManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WawasanKebangsaanBase;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class WKSigleton : MonoBehaviour
{
    public static WKSigleton Instance { get; private set; }

    public static WKSigleton LoadSigleton()
    {
        GameObject go = new GameObject("SystemSigleton");
        go.AddComponent<WKSigleton>();

        WKSigleton sigleton = go.GetComponent<WKSigleton>() as WKSigleton;

        return sigleton;
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            if (Instance == null)
            {
                Instantiate(Instance);
                WKStaticFunction.WKMessageError("error when trying to create singleton");
            }
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
