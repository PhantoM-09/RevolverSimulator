using Assets.Scripts.ScriptsForElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
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
    private static float _minVal = 2.2f;
    public static float MinVal
    {
        get
        {
            return _minVal;
        }
        set
        {
            _minVal = value;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool f;
    // Update is called once per frame
    void Update()
    {
        if(!_isMove)
        {
            if (TriggerScript.OpenForDog)
            {
                if (_offset < 1)
                    _offset += HelperWithElements.Speed;

                float value = gameObject.transform.rotation.x;

                value = Mathf.Clamp(value, _minVal, 0f);

                if (_minVal < 8.0f)
                {
                    _minVal = _minVal + 0.2f;
                }

                gameObject.transform.rotation = Quaternion.Euler(new Vector3(value, 0, 0));

                if (gameObject.transform.rotation.eulerAngles.x >= 8f && _minVal == 7.8f)
                {
                    TriggerScript.OpenForDog = false;
                    _offset = 0;
                }
            }
        }
        else
        {
            if(HigherTriggerScript.OpenForDogBack)
            {
                if (_offset < 1)
                    _offset += HelperWithElements.Speed;

                Quaternion endPosition = Quaternion.Euler(0f, 0f, 0f);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);

                gameObject.transform.rotation = newPosition;
                
                if(gameObject.transform.rotation.eulerAngles.x <= 0f)
                {
                    HigherTriggerScript.OpenForDogBack = false;
                    _offset = 0;
                }
            }
        }
    }


}
