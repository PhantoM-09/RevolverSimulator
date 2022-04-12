using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelperWithGame : MonoBehaviour
{
    public Text All;
    public Text Good;
    public Text Bad;
    public Text Summ;
    private static int _countShootingBullets = 0;

    public static int g;
    public static int CountShootingBullets
    {
        get
        {
            return _countShootingBullets;
        }
        set
        {
            _countShootingBullets = value;
        }
    }

    private static bool _openForAim = false;
    public static bool OpenForAim
    {
        get
        {
            return _openForAim;
        }
        set
        {
            _openForAim = value;
        }
    }

    private static int _hittingBullets = 0;
    public static int HittingBullets
    {
        get
        {
            return _hittingBullets;
        }
        set
        {
            _hittingBullets = value;
        }
    }

    private static int _resultOfGame = 0;
    public static int ResultOfGame
    {
        get
        {
            return _resultOfGame;
        }
        set
        {
            _resultOfGame = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        All.text = 7.ToString();
        Good.text = _hittingBullets.ToString();
        Bad.text = (7 - _hittingBullets).ToString();
        Summ.text = _resultOfGame.ToString();
    }
}
