using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryButton : MonoBehaviour
{
    private static bool _firstBulletBack = false;
    public static bool FirstBulletBack
    {
        get
        {
            return _firstBulletBack;
        }
        set
        {
            _firstBulletBack = value;
        }
    }
    private static bool _secondBulletBack = false;
    public static bool SecondBulletBack
    {
        get
        {
            return _secondBulletBack;
        }
        set
        {
            _secondBulletBack = value;
        }
    }
    private static bool _thirdBulletBack = false;
    public static bool ThirdBulletBack
    {
        get
        {
            return _thirdBulletBack;
        }
        set
        {
            _thirdBulletBack = value;
        }
    }
    private static bool _fourthBulletBack = false;
    public static bool FourthBulletBack
    {
        get
        {
            return _fourthBulletBack;
        }
        set
        {
            _fourthBulletBack = value;
        }
    }
    private static bool _fifthBulletBack = false;
    public static bool FifthBulletBack
    {
        get
        {
            return _fifthBulletBack;
        }
        set
        {
            _fifthBulletBack = value;
        }
    }
    private static bool _sixthBulletBack = false;
    public static bool SixthBulletBack
    {
        get
        {
            return _sixthBulletBack;
        }
        set
        {
            _sixthBulletBack = value;
        }
    }

    private static bool _seventhBulletBack = false;
    public static bool SeventhBulletBack
    {
        get
        {
            return _seventhBulletBack;
        }
        set
        {
            _seventhBulletBack = value;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject panelWithResult;
    public GameObject firstAim;
    public GameObject secondAim;
    public GameObject thirdAim;
    public GameObject fourthAim;
    public GameObject fifthAim;
    public GameObject sixthAim;
    public GameObject seventhAim;

    public void Retry()
    {
        Cursor.visible = false;

        FirstBulletBack = true;
        SecondBulletBack = true;
        ThirdBulletBack = true;
        FourthBulletBack = true;
        FifthBulletBack = true;
        SixthBulletBack = true;
        SeventhBulletBack = true;

        HelperWithGame.CountShootingBullets = 0;
        HelperWithGame.HittingBullets = 0;
        HelperWithGame.ResultOfGame = 0;

        HelperTarget.bulletCounter = 0;

        firstAim.SetActive(true);
        secondAim.SetActive(true);
        thirdAim.SetActive(true);
        fourthAim.SetActive(true);
        fifthAim.SetActive(true);
        sixthAim.SetActive(true);
        seventhAim.SetActive(true);
        panelWithResult.SetActive(false);
    }
}
