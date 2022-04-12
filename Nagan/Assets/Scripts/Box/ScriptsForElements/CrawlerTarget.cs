using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerTarget : MonoBehaviour
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

    private static bool _openForBreech = false;
    public static bool OpenForBreech
    {
        get
        {
            return _openForBreech;
        }
        set
        {
            _openForBreech = value;
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

    private static bool _openForBreechBack = false;
    public static bool OpenForBreechBack
    {
        get
        {
            return _openForBreechBack;
        }
        set
        {
            _openForBreechBack = value;
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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!_isMove)
        {
            if (TriggerTarget.OpenForCrawler)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, 72.81f, gameObject.transform.localPosition.z), _offset);

                if (gameObject.transform.localPosition.y >= 66.5f)
                {
                    _openForBreech = true;
                }

                if (gameObject.transform.localPosition.y >= 72.81f)
                {
                    TriggerTarget.OpenForCrawler = false;
                    _offset = 0;
                }
            }
        }
        else
        {
            if (TriggerTarget.OpenForCrawler)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                Vector3 newPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, 59.1875f, gameObject.transform.localPosition.z), _offset);
                gameObject.transform.localPosition = newPosition;

                if (gameObject.transform.localPosition.y <= 69f)
                {
                    _openForRevolver = true;
                    _openForBreechBack = true;
                }

                if (gameObject.transform.localPosition.y <= 59.1875f)
                {
                    TriggerTarget.OpenForCrawler = false;
                    _offset = 0;
                }
            }
        }
    }
}
