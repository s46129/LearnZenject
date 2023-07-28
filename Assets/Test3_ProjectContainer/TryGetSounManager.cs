using System;
using System.Collections;
using System.Collections.Generic;
using Test3_ProjectContainer;
using UnityEngine;
using Zenject;

public class TryGetSounManager : MonoBehaviour
{
    [Inject] [SerializeField] private SoundManager _soundManager;


    private void Start()
    {
        _soundManager.Trigger();
    }
}