using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRamrod : MonoBehaviour
{
    private static float _offsetMoveXY = 0;
    public static float OffsetMoveXY
    {
        get
        {
            return _offsetMoveXY;
        }
        set
        {
            _offsetMoveXY = value;
        }
    }

    private static float _offsetMoveZ = 0;
    public static float OffsetMoveZ
    {
        get
        {
            return _offsetMoveZ;
        }
        set
        {
            _offsetMoveZ = value;
        }
    }

    //-----------------------------------------

    private static bool _canRamrodMove = false;
    public static bool CanRamrodMove
    {
        get
        {
            return _canRamrodMove;
        }
        set
        {
            _canRamrodMove = value;
        }
    }

    private static bool _moveToMainPosition = false;
    public static bool MoveToMainPosition
    {
        get
        {
            return _moveToMainPosition;
        }
        set
        {
            _moveToMainPosition = value;
        }
    }

    private static bool _moveToZ = true;
    public static bool MoveToZ
    {
        get
        {
            return _moveToZ;
        }
        set
        {
            _moveToZ = value;
        }
    }

    private static bool _moveToXY = false;
    public static bool MoveToXY
    {
        get
        {
            return _moveToXY;
        }
        set
        {
            _moveToXY = value;
        }
    }

    private static bool _canMoveForwardAndBack = false;
    public static bool CanMoveForwardAndBack
    {
        get
        {
            return _canMoveForwardAndBack;
        }
        set
        {
            _canMoveForwardAndBack = value;
        }
    }

    private static bool _openPutFirstShell = false;
    public static bool OpenPutFirstShell
    {
        get
        {
            return _openPutFirstShell;
        }
        set
        {
            _openPutFirstShell = value;
        }
    }

    void Start()
    {
        
    }

    public GameObject panelWithTextAboutNeedRecharge;
    public GameObject buttonRecharge;
    public GameObject door;
    public GameObject shell;
    void Update()
    {
        if(CanRamrodMove)
        {
            if(MoveToMainPosition)
            {
                panelWithTextAboutNeedRecharge.SetActive(false);
                buttonRecharge.SetActive(false);
                door.SetActive(false);
                if (MoveToZ)
                {
                    if (OffsetMoveZ < 1)
                        OffsetMoveZ += HelperWithRecharge.Speed;

                    gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 86f), OffsetMoveZ);

                    if (gameObject.transform.localPosition.z >= 86f)
                    {
                        OffsetMoveZ = 0;
                        MoveToZ = false;
                        MoveToXY = true;
                    }
                }
                else if(MoveToXY)
                {
                    if (OffsetMoveXY < 1)
                        OffsetMoveXY += HelperWithRecharge.Speed;

                    gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(9f, 36f, gameObject.transform.localPosition.z), OffsetMoveXY);

                    if (gameObject.transform.localPosition.x >= 9f && gameObject.transform.localPosition.y <= 36f)
                    {
                        OffsetMoveXY = 0;
                        _canMoveForwardAndBack = true;
                        MoveToXY = false;
                    }
                }
            }
            else
            {
                if (MoveToXY)
                {
                    if (OffsetMoveXY < 1)
                        OffsetMoveXY += HelperWithRecharge.Speed;

                    gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(-2.114258f, 38.36035f, gameObject.transform.localPosition.z), OffsetMoveXY);

                    if (gameObject.transform.localPosition.x <= -2f)
                    {
                        MoveToXY = false;
                        OffsetMoveXY = 0;
                        MoveToZ = true;
                    }
                }
                if (MoveToZ)
                {
                    if (OffsetMoveZ < 1)
                        OffsetMoveZ += HelperWithRecharge.Speed;

                    gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 13.61328f), OffsetMoveZ);

                    if (gameObject.transform.localPosition.z <= 13.61328f)
                    {
                        HelperWithRecharge.ApplyStartOptions();
                        OffsetMoveZ = 0;
                        MoveToZ = false;

                        OpenPutFirstShell = true;
                        shell.SetActive(true);
                        HelperWithRecharge.OpenReturnFifthBullet = true;
                    }
                }
            }
        }
    }

    public static void StartRecharge()
    {
        CanRamrodMove = true;
        MoveToMainPosition = true;
    }
}
