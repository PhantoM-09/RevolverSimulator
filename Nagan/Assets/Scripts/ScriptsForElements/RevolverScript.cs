using Assets.Scripts.ScriptsForElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverScript : MonoBehaviour
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
        if(!_isMove)
        {
            if (TriggerScript.OpenForRevolver)
            {
                if (_offset < 1)
                    _offset += HelperWithElements.Speed;

                Quaternion endPosition = Quaternion.Euler(0f, 0f, _zRotateRevolver);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);

                gameObject.transform.rotation = newPosition;

                if(gameObject.transform.rotation.eulerAngles.z -360 <= _zRotateRevolver)
                {
                    TriggerScript.OpenForRevolver = false;
                    _offset = 0;
                }
            }

            if (BreechScript.OpenForRevolver)
            {
                if (_additionalOffset < 1)
                    _additionalOffset += HelperWithElements.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, -28.1f), _additionalOffset);
            
                if(gameObject.transform.localPosition.z >= -28.1f)
                {
                    BreechScript.OpenForRevolver = false;
                    _additionalOffset = 0;
                    TriggerScript.CanClick = true;
                }
            }
        }
        else
        {
            if(CrawlerScript.OpenForRevolver)
            {
                if (_offset < 1)
                    _offset += HelperWithElements.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, -30.77734f), _offset);
                
                if (gameObject.transform.localPosition.z <= -30.77734f)
                {
                    HigherTriggerScript.CanClick = true;

                    CrawlerScript.OpenForRevolver = false;
                    _offset = 0;
                }
            }
        }
    }


}//-43.831
