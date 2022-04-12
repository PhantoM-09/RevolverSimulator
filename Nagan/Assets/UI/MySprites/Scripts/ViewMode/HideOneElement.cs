using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOneElement : MonoBehaviour
{
    public GameObject LeftPart;

    public void HideElement()
    {
        LeftPart.SetActive(false);
    }
}
