using StrategyEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public Image Img;

    public Action<string> MenuAction;

    private string _itemDataID;

    public void Clicked() {
        MenuAction(_itemDataID);
    }

    internal void SetData(EntityData data) {
        Img.sprite = data.Image;
        _itemDataID = data.DataID;
    }
}
