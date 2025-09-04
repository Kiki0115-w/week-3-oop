using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OOPExit : Identity
{
    public GameObject youWinUI;

    public override void Hit()
    {
       youWinUI.SetActive(true);
    }
}
