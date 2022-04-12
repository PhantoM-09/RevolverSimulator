using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForChangeSkin : MonoBehaviour
{
    public GameObject panelWithSkins;
    // Start is called before the first frame update
    void Start()
    {
        panelWithSkins.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowPanel()
    {
        panelWithSkins.SetActive(true);
    }

    public void HidePanel()
    {
        panelWithSkins.SetActive(false);
    }
}
