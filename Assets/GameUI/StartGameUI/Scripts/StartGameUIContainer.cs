using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameUIContainer : MonoBehaviour
{
    [SerializeField] private PlayButtonUI _playButtonUI;
    public PlayButtonUI PlayButtonUI => _playButtonUI;
}