using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverTarget : MonoBehaviour
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

    private static bool _isMove = false;
    public static bool IsMove
    {
        get
        {
            return _isMove;
        }
        set
        {
            _isMove = value;
        }
    }

    private static float _zRotateRevolver;
    public static float ZRotateRevolver
    {
        get
        {
            return _zRotateRevolver;
        }
        set
        {
            _zRotateRevolver = value;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        if (!_isMove)
        {
            if (TriggerTarget.OpenForRevolver)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                Quaternion endPosition = Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, _zRotateRevolver);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);

                gameObject.transform.rotation = newPosition;

                if (gameObject.transform.rotation.eulerAngles.z - 360 <= _zRotateRevolver)
                {
                    TriggerTarget.OpenForRevolver = false;
                    _offset = 0;
                }
            }

            if (BreechTarget.OpenForRevolver)
            {
                if (_additionalOffset < 1)
                    _additionalOffset += HelperTarget.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, -28.1f), _additionalOffset);

                if (gameObject.transform.localPosition.z >= -28.1f)
                {
                    BreechTarget.OpenForRevolver = false;
                    _additionalOffset = 0;
                    TriggerTarget.CanClick = true;
                }
            }
        }
        else
        {
            if (CrawlerTarget.OpenForRevolver)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, -30.77734f), _offset);

                if (gameObject.transform.localPosition.z <= -30.77734f)
                {
                    HigherTriggerTarget.CanClick = true;

                    CrawlerTarget.OpenForRevolver = false;
                    _offset = 0;
                }
            }
        }
    }

}
