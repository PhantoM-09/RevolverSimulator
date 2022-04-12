using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBulletTarget : MonoBehaviour
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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!RetryButton.FirstBulletBack)
        {
            if (HigherTriggerTarget.OpenForFirstBullet)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                Vector3 newPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(Vector3.forward.x, gameObject.transform.localPosition.y, HelperTarget.BulletDistance), _offset);

                gameObject.transform.localPosition = newPosition;
                if (gameObject.transform.localPosition.z >= HelperTarget.BulletDistance)
                {
                    HigherTriggerTarget.OpenForFirstBullet = false;
                    _offset = 0;
                }
            }
        }
        else
        {
            Vector3 newPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 16.22742f);

            gameObject.transform.localPosition = newPosition;
            RetryButton.FirstBulletBack = false;
        }
    }


    
}
