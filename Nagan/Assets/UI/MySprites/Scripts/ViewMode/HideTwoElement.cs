using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTwoElement : MonoBehaviour
{
    public GameObject RightPart;
    public GameObject LeftPart;

    public void HideElements()
    {
        RightPart.SetActive(false);
        LeftPart.SetActive(false);
    }
}
