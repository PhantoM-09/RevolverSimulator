using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperWithRecharge : MonoBehaviour
{
    private static Shader _baseShellShader;
    private static float _speed = 0.07f;
    public static float Speed
    {
        get
        {
            return _speed;
        }
    }

    private static int _deleteBulletCounter = 0;
    public static int DeleteBulletCounter
    {
        get
        {
            return _deleteBulletCounter;
        }
        set
        {
            _deleteBulletCounter = value;
        }
    }

    private static int _putBulletCounter = 0;
    public static int PutBulletCounter
    {
        get
        {
            return _putBulletCounter;
        }
        set
        {
            _putBulletCounter = value;
        }
    }

    private static bool _openReturnFifthBullet = false;
    public static bool OpenReturnFifthBullet
    {
        get
        {
            return _openReturnFifthBullet;
        }
        set
        {
            _openReturnFifthBullet = value;
        }
    }

    private static bool _openReturnSixthBullet = false;
    public static bool OpenReturnSixthBullet
    {
        get
        {
            return _openReturnSixthBullet;
        }
        set
        {
            _openReturnSixthBullet = value;
        }
    }

    private static bool _openReturnSeventhBullet = false;
    public static bool OpenReturnSeventhBullet
    {
        get
        {
            return _openReturnSeventhBullet;
        }
        set
        {
            _openReturnSeventhBullet = value;
        }
    }

    private static bool _openReturnFirstBullet = false;
    public static bool OpenReturnFirstBullet
    {
        get
        {
            return _openReturnFirstBullet;
        }
        set
        {
            _openReturnFirstBullet = value;
        }
    }

    private static bool _openReturnSecondBullet = false;
    public static bool OpenReturnSecondBullet
    {
        get
        {
            return _openReturnSecondBullet;
        }
        set
        {
            _openReturnSecondBullet = value;
        }
    }

    private static bool _openReturnThirdBullet = false;
    public static bool OpenReturnThirdBullet
    {
        get
        {
            return _openReturnThirdBullet;
        }
        set
        {
            _openReturnThirdBullet = value;
        }
    }

    private static bool _openReturnFourthBullet = false;
    public static bool OpenReturnFourthBullet
    {
        get
        {
            return _openReturnFourthBullet;
        }
        set
        {
            _openReturnFourthBullet = value;
        }
    }
    private void Start()
    {
        
    }

    public static void ApplyStartOptions()
    {
        CleanAllOpens();
        ReturnOtherValues();
        ZeroAllOffset();
    }

    private static void CleanAllOpens()
    {
        MoveRamrod.CanRamrodMove = false;
        MoveRamrod.MoveToMainPosition = false;
        MoveRamrod.MoveToZ = true;
        MoveRamrod.MoveToXY = false;
        MoveRamrod.CanMoveForwardAndBack = false;
        MoveRamrod.OpenPutFirstShell = false;


        MoveRamrodForwardAndBack.MoveBack = true;
        MoveRamrodForwardAndBack.MoveForward = false;
        MoveRamrodForwardAndBack.CanRotateRevolver = false;
        MoveRamrodForwardAndBack.OpenForFirstShell = false;
        MoveRamrodForwardAndBack.OpenForSecondShell = false;
        MoveRamrodForwardAndBack.OpenForThirdShell = false;
        MoveRamrodForwardAndBack.OpenForFourthShell = false;
        MoveRamrodForwardAndBack.OpenForFifthShell = false;
        MoveRamrodForwardAndBack.OpenForSixthShell = false;
        MoveRamrodForwardAndBack.OpenForSeventhShell = false;

        RevolverRotater.OpenPutSecondShell = false;
        RevolverRotater.OpenPutThirdShell = false;
        RevolverRotater.OpenPutFourthShell = false;
        RevolverRotater.OpenPutFifthShell = false;
        RevolverRotater.OpenPutSixthShell = false;
        RevolverRotater.OpenPutSeventhShell = false;
        RevolverRotater.DeleteRotate = true;
    }

    private static void ZeroAllOffset()
    {
        MoveRamrod.OffsetMoveXY = 0;
        MoveRamrod.OffsetMoveZ = 0;

        MoveRamrodForwardAndBack.OffsetMoveBack = 0;
        MoveRamrodForwardAndBack.OffsetMoveForward = 0;

        RevolverRotater.OffsetRotateDelete = 0;
        RevolverRotater.OffsetRotatePut = 0;

        RevolverRotater.DeleteZRotate = 0;
        RevolverRotater.PutZRotate = 0;

        FifthShell.OffsetMoveBack = 0;
        FirstShell.OffsetMoveBack = 0;
        FourthShell.OffsetMoveBack = 0;
        SecondShell.OffsetMoveBack = 0;
        SeventhShell.OffsetMoveBack = 0;
        SixthShell.OffsetMoveBack = 0;
        ThirdShell.OffsetMoveBack = 0;
    }

    private static void ReturnOtherValues()
    {
        _deleteBulletCounter = 0;
        _putBulletCounter = 0;
        _openReturnFifthBullet = false;
        _openReturnSixthBullet = false;
        _openReturnSeventhBullet = false;
        _openReturnFirstBullet = false;
        _openReturnSecondBullet = false;
        _openReturnThirdBullet = false;
        _openReturnFourthBullet = false;
    }

    public static float CalculateDeleteZRotate()
    {
        DeleteBulletCounter++;
        return -52f * _deleteBulletCounter;
    }

    public static float CalculatePutZRotate()
    {
        PutBulletCounter++;
        return -52f * PutBulletCounter;
    }


}
