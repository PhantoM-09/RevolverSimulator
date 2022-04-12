using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HigherTriggerTarget : MonoBehaviour
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

    private static bool _isClick = false;
    public static bool IsClick
    {
        get
        {
            return _isClick;
        }
        set
        {
            _isClick = value;
        }
    }

    private static bool _openForTrigger = false;
    public static bool OpenForTrigger
    {
        get
        {
            return _openForTrigger;
        }
        set
        {
            _openForTrigger = value;
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

    private static bool _openForFirstBullet = false;
    public static bool OpenForFirstBullet
    {
        get
        {
            return _openForFirstBullet;
        }
        set
        {
            _openForFirstBullet = value;
        }
    }


    private static bool _openForSecondBullet = false;
    public static bool OpenForSecondBullet
    {
        get
        {
            return _openForSecondBullet;
        }
        set
        {
            _openForSecondBullet = value;
        }
    }


    private static bool _openForThirdBullet = false;
    public static bool OpenForThirdBullet
    {
        get
        {
            return _openForThirdBullet;
        }
        set
        {
            _openForThirdBullet = value;
        }
    }


    private static bool _openForFourthBullet = false;
    public static bool OpenForFourthBullet
    {
        get
        {
            return _openForFourthBullet;
        }
        set
        {
            _openForFourthBullet = value;
        }
    }


    private static bool _openForFifthBullet = false;
    public static bool OpenForFifthBullet
    {
        get
        {
            return _openForFifthBullet;
        }
        set
        {
            _openForFifthBullet = value;
        }
    }


    private static bool _openForSixthBullet = false;
    public static bool OpenForSixthBullet
    {
        get
        {
            return _openForSixthBullet;
        }
        set
        {
            _openForSixthBullet = value;
        }
    }


    private static bool _openForSeventhBullet = false;
    public static bool OpenForSeventhBullet
    {
        get
        {
            return _openForSeventhBullet;
        }
        set
        {
            _openForSeventhBullet = value;
        }
    }

    private static bool _openForTriggerBack = false;
    public static bool OpenForTriggerBack
    {
        get
        {
            return _openForTriggerBack;
        }
        set
        {
            _openForTriggerBack = value;
        }
    }

    private static bool _openForDogBack = false;
    public static bool OpenForDogBack
    {
        get
        {
            return _openForDogBack;
        }
        set
        {
            _openForDogBack = value;
        }
    }

    private static bool _openForAllModel = false;
    public static bool OpenForAllModel
    {
        get
        {
            return _openForAllModel;
        }
        set
        {
            _openForAllModel = value;
        }
    }

    private static bool _canClick = true;
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


    public AudioClip shootSound;
    public AudioClip platoonSound;
    private AudioSource _audioSource;
    public ParticleSystem Flash;
    public GameObject panelWithResult;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        panelWithResult.SetActive(false);
    }

    void Update()
    {
        if(HelperWithGame.OpenForAim)
        {
            if (Input.GetMouseButtonDown(1))
            {
                _audioSource.PlayOneShot(platoonSound);
                Click();
            }
        }

        if (!_isMove)
        {
            if (_isClick)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;
                Quaternion newPosition = Quaternion.Euler(-45f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);
                gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, newPosition, _offset);

                if (gameObject.transform.rotation.eulerAngles.x - 360 <= -45f)
                {
                    _offset = 0;
                    _isClick = false;
                }
            }
        }
        else
        {
            if (TriggerTarget.OpenForHigherTrigger)
            {
                if (_offset < 1)
                    _offset += HelperTarget.Speed;

                Quaternion endPosition = Quaternion.Euler(5.114f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);

                Quaternion newPosition = Quaternion.Slerp(gameObject.transform.rotation, endPosition, _offset);
                gameObject.transform.rotation = newPosition;

                if (gameObject.transform.rotation.eulerAngles.x <= 5.114f)
                {
                    switch (HelperTarget.bulletCounter)
                    {
                        case 1: _openForFirstBullet = true; break;
                        case 2: _openForSecondBullet = true; break;
                        case 3: _openForThirdBullet = true; break;
                        case 4: _openForFourthBullet = true; break;
                        case 5: _openForFifthBullet = true; break;
                        case 6: _openForSixthBullet = true; break;
                        case 7: _openForSeventhBullet = true; break;
                    }

                    _audioSource.PlayOneShot(shootSound);
                    Flash.Play();
                    HigherTriggerTarget.OpenForTriggerBack = true;
                    HigherTriggerTarget.OpenForDogBack = true;
                    TriggerTarget.OpenForHigherTrigger = false;
                    _offset = 0;
                }

            }

            if (TriggerTarget.OpenForHigherTriggerBack)
            {
                if (_additionalOffset < 1)
                    _additionalOffset += HelperTarget.Speed;

                Quaternion newPosition = Quaternion.Euler(0f, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z);
                gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, newPosition, _additionalOffset);

                if (gameObject.transform.rotation.eulerAngles.x <= 0f)
                {
                    TriggerTarget.OpenForHigherTriggerBack = false;
                    _additionalOffset = 0;
                }
            }
        }

    }


    public void Click()
    {
        if (HelperTarget.bulletCounter < 7)
        {
            if (_canClick)
            {
                HelperTarget.ApplyStartOptions();

                _openForTrigger = true;
                _isClick = true;
                _canClick = false;
            }
        }
        else
        {
            
            panelWithResult.SetActive(true);
            Cursor.visible = true;
        }
    }
}
