using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideTable : MonoBehaviour
{
    public GameObject table;
    // Start is called before the first frame update
    void Start()
    {
        table.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowTable()
    {
        table.SetActive(true);
    }

    public void HideTable()
    {
        table.SetActive(false);
    }
}
