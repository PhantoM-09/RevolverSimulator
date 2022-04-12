using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllModel : MonoBehaviour
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

    private static bool _moveBack = false;
    public static bool MoveBack
    {
        get
        {
            return _moveBack;
        }
        set
        {
            _moveBack = value;
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if(!_moveBack)
    //    {
    //        if (HigherTriggerTarget.OpenForAllModel)
    //        {
    //            if (_offset < 1)
    //                _offset += HelperTarget.Speed;

    //            Quaternion newPosition = Quaternion.Euler(-9f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);
    //            gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, newPosition, _offset);

    //            if (gameObject.transform.rotation.eulerAngles.x - 360 <= -9f)
    //            {
    //                _offset = 0;
    //                HigherTriggerTarget.OpenForAllModel = false;
    //                _moveBack = true;
    //            }
    //        }
    //    }
    //    else
    //    {
    //        if (_offset < 1)
    //            _offset += HelperTarget.Speed;

    //        Quaternion newPosition = Quaternion.Euler(0f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);
    //        gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, newPosition, _offset);

    //        if (gameObject.transform.rotation.eulerAngles.x <= 0f)
    //        {
    //            _offset = 0;
    //            _moveBack = false;
    //            gameObject.transform.rotation = Quaternion.Euler(0f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

    //            HigherTriggerTarget.OpenForTriggerBack = true;
    //            HigherTriggerTarget.OpenForDogBack = true;
    //        }
    //    }
        
    //}
}
