using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerTarget : MonoBehaviour
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

    private static bool _openForDog = false;
    public static bool OpenForDog
    {
        get
        {
            return _openForDog;
        }
        set
        {
            _openForDog = value;
        }
    }

    private static bool _openForRevolver = false;
    public static bool OpenForRevolver
    {
        get
        {
            return _openForRevolver;
        }
        set
        {
            _openForRevolver = value;
        }
    }

    private static bool _openForCrawler = false;
    public static bool OpenForCrawler
    {
        get
        {
            return _openForCrawler;
        }
        set
        {
            _openForCrawler = value;
        }
    }

    private static bool _openForHigherTrigger = false;
    public static bool OpenForHigherTrigger
    {
        get
        {
            return _openForHigherTrigger;
        }
        set
        {
            _openForHigherTrigger = value;
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

    private static bool _openForLinkForward = false;
    public static bool OpenForLinkForward
    {
        get
        {
            return _openForLinkForward;
        }
        set
        {
            _openForLinkForward = value;
        }
    }

    private static bool _openForLinkBack = false;
    public static bool OpenForLinkBack
    {
        get
        {
            return _openForLinkBack;
        }
        set
        {
            _openForLinkBack = value;
        }
    }

    private static bool _canClick = false;
    public static bool CanClick
    {
        get
        {
            return _canClick;
        }
        set
        {
            _canClick = value;
        }
    }

    private static bool _canMove = false;
    public static bool CanMove
    {
        get
        {
            return _canMove;
        }
        set
        {
            _canMove = value;
        }
    }

    private static bool _openForHigherTriggerBack = false;
    public static bool OpenForHigherTriggerBack
    {
        get
        {
            return _openForHigherTriggerBack;
        }
        set
        {
            _openForHigherTriggerBack = value;
        }
    }

    private static bool _firstTimeRevolverAndDog = false;
    public static bool FirstTimeRevolverAndDog
    {
        get
        {
            return _firstTimeRevolverAndDog;
        }
        set
        {
            _firstTimeRevolverAndDog = value;
        }
    }
    private static bool _firstTimeCrawler = false;
    public static bool FirstTimeCrawler
    {
        get
        {
            return _firstTimeCrawler;
        }
        set
        {
            _firstTimeCrawler = value;
        }
    }
    void Start()
    {

    }

    public bool f;
    void Update()
    {
        if(HelperWithGame.OpenForAim)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Click();
            }
        }

        if (!_isMove)
        {
            if (HigherTriggerTarget.OpenForTrigger)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;
                Quaternion endPosition = Quaternion.Euler(30.211f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);

                gameObject.transform.rotation = newPosition;

                if (gameObject.transform.rotation.eulerAngles.x >= 3.5f && !_firstTimeRevolverAndDog)
                {
                    _openForDog = true;

                    RevolverTarget.ZRotateRevolver = HelperTarget.CalculateZRotateRevolver();

                    _openForRevolver = true;
                    _firstTimeRevolverAndDog = true;
                }

                if (gameObject.transform.rotation.eulerAngles.x >= 4.5f && !_firstTimeCrawler)
                {
                    _openForCrawler = true;
                    _firstTimeCrawler = true;
                }

                if (gameObject.transform.rotation.eulerAngles.x >= 30.2f)
                {
                    _offset = 0;
                    _firstTimeRevolverAndDog = false;
                    _firstTimeCrawler = false;
                    HigherTriggerTarget.OpenForTrigger = false;
                }
            }
        }
        else
        {
            if (_canMove)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                Quaternion endPosition = Quaternion.Euler(32f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);
                gameObject.transform.rotation = newPosition;

                if (gameObject.transform.rotation.eulerAngles.x >= 31.6f)
                {
                    _canMove = false;
                    _offset = 0;
                    _openForHigherTrigger = true;
                }


            }

            if (HigherTriggerTarget.OpenForTriggerBack)
            {
                if (_additionalOffset < 1)
                    _additionalOffset += HelperTarget.Speed;

                Quaternion endPosition = Quaternion.Euler(0f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _additionalOffset);

                gameObject.transform.rotation = newPosition;

                if (gameObject.transform.rotation.eulerAngles.x <= 31f)
                {
                    _openForLinkForward = true;
                }

                if (gameObject.transform.rotation.eulerAngles.x <= 28f)
                {
                    _openForCrawler = true;
                    _openForHigherTriggerBack = true;
                }

                if (gameObject.transform.rotation.eulerAngles.x <= 13f)
                {
                    _openForLinkForward = false;
                    _openForLinkBack = true;
                }

                if (gameObject.transform.rotation.eulerAngles.x <= 0f)
                {
                    HigherTriggerTarget.OpenForTriggerBack = false;
                    _additionalOffset = 0;
                }
            }
        }
    }

    public void Click()
    {
        if (_canClick)
        {
            HelperTarget.MakeIsMove();

            //optional
            HelperTarget.MakeStatusOpenFalse();
            HelperTarget.MakeOffsetZero();
            _canMove = true;
            _canClick = false;

            
        }
    }
}
