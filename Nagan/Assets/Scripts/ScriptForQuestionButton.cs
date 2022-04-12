using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptForQuestionButton : MonoBehaviour
{
    private static Sprite _baseSprite;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ShowInfoPanel()
    {
        gameObject.SetActive(true);
    }

    public void HideInfoPanel()
    {
        gameObject.SetActive(false);
    }
}
