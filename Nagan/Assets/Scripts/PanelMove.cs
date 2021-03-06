using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelMove : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    GameObject FirstPos;
    [SerializeField]
    GameObject SecondPos;
    float speed = 0.01f;
    float offset = 0;
    bool open=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(open)
        {
            if(offset<1)offset += speed;
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, SecondPos.transform.position, offset);
        }
        else
        {
            if (offset < 1) offset += speed;
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, FirstPos.transform.position, offset);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
         offset=0;
        open = true;
            
            
    }

    public void OnPointerExit(PointerEventData eventData)
    {
         offset = 0;
        open = false;

    }
}
