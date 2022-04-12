using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreechTarget : MonoBehaviour
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
            _offset = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!_isMove)
        {
            if (CrawlerTarget.OpenForBreech)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                Quaternion endPosition = Quaternion.Euler(7.9f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);

                gameObject.transform.rotation = newPosition;

                if (gameObject.transform.rotation.eulerAngles.x >= 3.6f)
                {
                    _openForRevolver = true;
                }

                if (gameObject.transform.rotation.eulerAngles.x >= 7.9f)
                {
                    CrawlerTarget.OpenForBreech = false;
                    _offset = 0;
                }
            }
        }
        else
        {
            if (CrawlerTarget.OpenForBreechBack)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                Quaternion endPosition = Quaternion.Euler(0f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);

                gameObject.transform.rotation = newPosition;

                if (gameObject.transform.rotation.eulerAngles.x <= 0f)
                {
                    CrawlerTarget.OpenForBreechBack = false;
                    _offset = 0;
                }
            }
        }
    }
}
