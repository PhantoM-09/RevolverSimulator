using Assets.Scripts.ScriptsForElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverRotater : MonoBehaviour
{
    private static float _offsetRotateDelete = 0;
    public static float OffsetRotateDelete
    {
        get
        {
            return _offsetRotateDelete;
        }
        set
        {
            _offsetRotateDelete = value;
        }
    }

    private static float _offsetRotatePut = 0;
    public static float OffsetRotatePut
    {
        get
        {
            return _offsetRotatePut;
        }
        set
        {
            _offsetRotatePut = value;
        }
    }

    private static float _deleteZRotate;
    public static float DeleteZRotate
    {
        get
        {
            return _deleteZRotate;
        }
        set
        {
            _deleteZRotate = value;
        }
    }

    private static float _putZRotate;
    public static float PutZRotate
    {
        get
        {
            return _putZRotate;
        }
        set
        {
            _putZRotate = value;
        }
    }

    private static bool _deleteRotate = true;
    public static bool DeleteRotate
    {
        get
        {
            return _deleteRotate;
        }
        set
        {
            _deleteRotate = value;
        }
    }

    private static bool _openPutSecondShell;
    public static bool OpenPutSecondShell
    {
        get
        {
            return _openPutSecondShell;
        }
        set
        {
            _openPutSecondShell = value;
        }
    }

    private static bool _openPutThirdShell;
    public static bool OpenPutThirdShell
    {
        get
        {
            return _openPutThirdShell;
        }
        set
        {
            _openPutThirdShell = value;
        }
    }

    private static bool _openPutFourthShell;
    public static bool OpenPutFourthShell
    {
        get
        {
            return _openPutFourthShell;
        }
        set
        {
            _openPutFourthShell = value;
        }
    }

    private static bool _openPutFifthShell;
    public static bool OpenPutFifthShell
    {
        get
        {
            return _openPutFifthShell;
        }
        set
        {
            _openPutFifthShell = value;
        }
    }

    private static bool _openPutSixthShell;
    public static bool OpenPutSixthShell
    {
        get
        {
            return _openPutSixthShell;
        }
        set
        {
            _openPutSixthShell = value;
        }
    }

    private static bool _openPutSeventhShell;
    public static bool OpenPutSeventhShell
    {
        get
        {
            return _openPutSeventhShell;
        }
        set
        {
            _openPutSeventhShell = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject door;
    public GameObject secondShell;
    public GameObject thirdShell;
    public GameObject fourthShell;
    public GameObject fifthShell;
    public GameObject sixthShell;
    public GameObject seventhShell;
    // Update is called once per frame
    void Update()
    {
        if(DeleteRotate)
        {
            if (MoveRamrodForwardAndBack.CanRotateRevolver)
            {
                if (OffsetRotateDelete < 1)
                    OffsetRotateDelete += HelperWithElements.Speed;
                Quaternion newPosition = Quaternion.Euler(0f, 0f, DeleteZRotate);
                gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, newPosition, OffsetRotateDelete);

                if (gameObject.transform.rotation.eulerAngles.z - 360 <= DeleteZRotate)
                {
                    MoveRamrodForwardAndBack.CanRotateRevolver = false;
                    MoveRamrodForwardAndBack.MoveBack = true;
                    OffsetRotateDelete = 0;
                }

                if (gameObject.transform.rotation.eulerAngles.z - 360 == -4f)
                {
                    OffsetRotateDelete = 0;
                    MoveRamrod.MoveToMainPosition = false;
                    MoveRamrod.MoveToXY = true;
                }
            }
        }
        else
        {
            if (MoveRamrodForwardAndBack.CanRotateRevolver)
            {
                if (OffsetRotatePut < 1)
                    OffsetRotatePut += HelperWithElements.Speed;

                Quaternion newPosition = Quaternion.Euler(0f, 0f, PutZRotate);
                gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, newPosition, OffsetRotatePut);

                if (gameObject.transform.rotation.eulerAngles.z - 360 <= PutZRotate)
                {

                    MoveRamrodForwardAndBack.CanRotateRevolver = false;
                    OffsetRotatePut = 0;

                    switch(HelperWithRecharge.PutBulletCounter)
                    {
                        case 2:
                            OpenPutThirdShell = true;
                            thirdShell.SetActive(true);
                            HelperWithRecharge.OpenReturnSeventhBullet = true;
                            break;
                        case 3:
                            OpenPutFourthShell = true;
                            fourthShell.SetActive(true);
                            HelperWithRecharge.OpenReturnFirstBullet = true;
                            break;
                        case 4:
                            OpenPutFifthShell = true;
                            fifthShell.SetActive(true);
                            HelperWithRecharge.OpenReturnSecondBullet = true;
                            break;
                        case 5:
                            OpenPutSixthShell = true;
                            sixthShell.SetActive(true);
                            HelperWithRecharge.OpenReturnThirdBullet = true;
                            break;
                        case 6:
                            OpenPutSeventhShell = true;
                            seventhShell.SetActive(true);
                            HelperWithRecharge.OpenReturnFourthBullet = true;
                            break;
                        case 1:
                            OpenPutSecondShell = true;
                            secondShell.SetActive(true);
                            HelperWithRecharge.OpenReturnSixthBullet = true;
                            break;
                    }
                }

                if (gameObject.transform.rotation.eulerAngles.z - 360 == -4f)
                {

                    door.SetActive(true);

                    ScriptForPractice.OpenClean = true;
                    
                    HelperWithElements.bulletCounter = 0;
                    HelperWithRecharge.ApplyStartOptions();
                }

            }
        }
        
    }
}
