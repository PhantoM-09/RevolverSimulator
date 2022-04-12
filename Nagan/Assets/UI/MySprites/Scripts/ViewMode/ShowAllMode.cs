using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAllMode : MonoBehaviour
{
    public GameObject RightPart;
    public GameObject LeftPart;
    
    public void ShowElements()
    {
        RightPart.SetActive(true);
        LeftPart.SetActive(true);
    }
}
