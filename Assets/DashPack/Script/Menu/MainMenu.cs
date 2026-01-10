using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Canvas LevelChooseCanvas;

    void Start()
    {
        OpenLevelChooseMenu(false);
    }

    public void OpenLevelChooseMenu(bool isOpenedNow)
    {
        LevelChooseCanvas.enabled = isOpenedNow;
    }
}
