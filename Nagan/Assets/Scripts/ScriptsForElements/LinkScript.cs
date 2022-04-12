using Assets.Scripts.ScriptsForElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkScript : MonoBehaviour
{
    private static float _offset = 0;
    public static float Offset
    {
        get
        {
            return _offset;
        }
        set
        {
            _offset = value;
        }
    }
    private static float _additionalOffset = 0;
    public static float AdditionalOffset
    {
        get
        {
            return _additionalOffset;
        }
        set
        {
            _additionalOffset = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(TriggerScript.OpenForLinkForward && !TriggerScript.OpenForLinkBack)
        {
            if (_offset < 1)
                _offset += HelperWithElements.Speed;

            Quaternion endPosition = Quaternion.Euler(15f, 0f, 0f);

            Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);
            
            gameObject.transform.rotation = newPosition;

            if(gameObject.transform.rotation.eulerAngles.x >= 15f)
            {
                TriggerScript.OpenForLinkForward = false;
                _offset = 0;
            }
        }
        if(TriggerScript.OpenForLinkBack)
        {
            if (_additionalOffset < 1)
                _additionalOffset += HelperWithElements.Speed;

            Quaternion endPosition = Quaternion.Euler(0f, 0f, 0f);

            Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _additionalOffset);

            gameObject.transform.rotation = newPosition;

            if(gameObject.transform.rotation.eulerAngles.x <= 0f)
            {
                _additionalOffset = 0;
                TriggerScript.OpenForLinkBack = false;
            }
        }
    }


}
//5.787