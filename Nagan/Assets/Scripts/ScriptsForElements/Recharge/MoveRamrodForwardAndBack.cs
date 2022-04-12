using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRamrodForwardAndBack : MonoBehaviour
{
    private static float _offsetMoveBack = 0;
    public static float OffsetMoveBack
    {
        get
        {
            return _offsetMoveBack;
        }
        set
        {
            _offsetMoveBack = value;
        }
    }

    private static float _offsetMoveForward = 0;
    public static float OffsetMoveForward
    {
        get
        {
            return _offsetMoveForward;
        }
        set
        {
            _offsetMoveForward = value;
        }
    }

    //-------------------------------

    private static bool _moveBack = true;
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

    private static bool _moveForward = false;
    public static bool MoveForward
    {
        get
        {
            return _moveForward;
        }
        set
        {
            _moveForward = value;
        }
    }

    private static bool _canRotateRevolver = false;
    public static bool CanRotateRevolver
    {
        get
        {
            return _canRotateRevolver;
        }
        set
        {
            _canRotateRevolver = value;
        }
    }

    private static bool _openForFirstShell;
    public static bool OpenForFirstShell
    {
        get
        {
            return _openForFirstShell;
        }
        set
        {
            _openForFirstShell = value;
        }
    }

    private static bool _openForSecondShell;
    public static bool OpenForSecondShell
    {
        get
        {
            return _openForSecondShell;
        }
        set
        {
            _openForSecondShell = value;
        }
    }

    private static bool _openForThirdShell;
    public static bool OpenForThirdShell
    {
        get
        {
            return _openForThirdShell;
        }
        set
        {
            _openForThirdShell = value;
        }
    }

    private static bool _openForFourthShell;
    public static bool OpenForFourthShell
    {
        get
        {
            return _openForFourthShell;
        }
        set
        {
            _openForFourthShell = value;
        }
    }

    private static bool _openForFifthShell;
    public static bool OpenForFifthShell
    {
        get
        {
            return _openForFifthShell;
        }
        set
        {
            _openForFifthShell = value;
        }
    }

    private static bool _openForSixthShell;
    public static bool OpenForSixthShell
    {
        get
        {
            return _openForSixthShell;
        }
        set
        {
            _openForSixthShell = value;
        }
    }

    private static bool _openForSeventhShell;
    public static bool OpenForSeventhShell
    {
        get
        {
            return _openForSeventhShell;
        }
        set
        {
            _openForSeventhShell = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveRamrod.CanMoveForwardAndBack)
        {
            if(MoveBack)
            {
                if (OffsetMoveBack < 1)
                    OffsetMoveBack += HelperWithRecharge.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, -2f), OffsetMoveBack);

                if(gameObject.transform.localPosition.z <= 4f)
                {
                    switch(HelperWithRecharge.DeleteBulletCounter + 1)
                    {
                        case 1: OpenForFirstShell = true; break;
                        case 2: OpenForSecondShell = true; break;
                        case 3: OpenForThirdShell = true; break;
                        case 4: OpenForFourthShell = true; break;
                        case 5: OpenForFifthShell = true; break;
                        case 6: OpenForSixthShell = true; break;
                        case 7: OpenForSeventhShell = true; break;
                    }
                }

                if(gameObject.transform.localPosition.z <= -2f)
                {
                    MoveBack = false;
                    MoveForward = true;
                    OffsetMoveBack = 0;
                }

            }
            else if(MoveForward)
            {
                if (OffsetMoveForward < 1)
                    OffsetMoveForward += HelperWithRecharge.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 86f), OffsetMoveForward);

                if(gameObject.transform.localPosition.z >= 86f)
                {
                    OffsetMoveForward = 0;
                    MoveForward = false;

                    RevolverRotater.DeleteZRotate = HelperWithRecharge.CalculateDeleteZRotate();
                    CanRotateRevolver = true;
                }
            }
        }
    }
}
