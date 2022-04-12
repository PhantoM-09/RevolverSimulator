using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkTarget : MonoBehaviour
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
        if (TriggerTarget.OpenForLinkForward && !TriggerTarget.OpenForLinkBack)
        {
            if (_offset < 1)
                _offset += HelperTarget.Speed;

            Quaternion endPosition = Quaternion.Euler(15f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

            Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);

            gameObject.transform.rotation = newPosition;

            if (gameObject.transform.rotation.eulerAngles.x >= 15f)
            {
                TriggerTarget.OpenForLinkForward = false;
                _offset = 0;
            }
        }
        if (TriggerTarget.OpenForLinkBack)
        {
            if (_additionalOffset < 1)
                _additionalOffset += HelperTarget.Speed;

            Quaternion endPosition = Quaternion.Euler(0f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

            Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _additionalOffset);

            gameObject.transform.rotation = newPosition;

            if (gameObject.transform.rotation.eulerAngles.x <= 0f)
            {
                _additionalOffset = 0;
                TriggerTarget.OpenForLinkBack = false;
            }
        }
    }

}
