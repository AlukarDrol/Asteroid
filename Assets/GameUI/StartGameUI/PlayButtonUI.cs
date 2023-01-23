using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayButtonUI : MonoBehaviour
{
    public event Action OnClick;
    public void Click()
    {
        OnClick?.Invoke();
    }
}