using Assets.Scripts.ScriptsForElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBulletScript : MonoBehaviour
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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!HelperWithRecharge.OpenReturnSecondBullet)
        {
            if (HigherTriggerScript.OpenForSecondBullet)
            {
                if (_offset < 1)
                    _offset += HelperWithElements.Speed;

                Vector3 newPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 1200f), _offset);

                gameObject.transform.localPosition = newPosition;

                if (gameObject.transform.localPosition.z >= 1200f)
                {
                    HigherTriggerScript.OpenForSecondBullet = false;
                    _offset = 0;
                }
            }

        }
        else
        {
            Vector3 newPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 16.22742f);

            gameObject.transform.localPosition = newPosition;


        }

        
    }
}
