using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperTarget : MonoBehaviour
{
    private static float _aimDistance = 2000f;
    public static float AimDistance
    {
        get
        {
            return _aimDistance;
        }
    }

    private static float _bulletDistance = 2260f;
    public static float BulletDistance
    {
        get
        {
            return _bulletDistance;
        }
    }
    private static float _speed = 0.08f;
    public static float Speed
    {
        get
        {
            return _speed;
        }
    }

    public static int bulletCounter = 0;
    public static void MakeIsMove()
    {
        HigherTriggerTarget.IsMove = true;
        TriggerTarget.IsMove = true;
        DogTarget.IsMove = true;
        CrawlerTarget.IsMove = true;
        RevolverTarget.IsMove = true;
        BreechTarget.IsMove = true;

    }

    public static void MakeIsNotMove()
    {
        HigherTriggerTarget.IsMove = false;
        TriggerTarget.IsMove = false;
        DogTarget.IsMove = false;
        CrawlerTarget.IsMove = false;
        RevolverTarget.IsMove = false;
        BreechTarget.IsMove = false;
    }

    public static void MakeStatusOpenFalse()
    {
        //HigherTriggerTarget

        HigherTriggerTarget.OpenForTrigger = false;
        HigherTriggerTarget.OpenForFirstBullet = false;
        HigherTriggerTarget.OpenForSecondBullet = false;
        HigherTriggerTarget.OpenForThirdBullet = false;
        HigherTriggerTarget.OpenForFourthBullet = false;
        HigherTriggerTarget.OpenForFifthBullet = false;
        HigherTriggerTarget.OpenForSixthBullet = false;
        HigherTriggerTarget.OpenForSeventhBullet = false;
        HigherTriggerTarget.OpenForTriggerBack = false;
        HigherTriggerTarget.OpenForDogBack = false;
        HigherTriggerTarget.OpenForAllModel = false;

        //TriggrScript
        TriggerTarget.OpenForDog = false;
        TriggerTarget.OpenForRevolver = false;
        TriggerTarget.OpenForCrawler = false;
        TriggerTarget.OpenForHigherTrigger = false;
        TriggerTarget.OpenForLinkForward = false;
        TriggerTarget.OpenForLinkBack = false;
        TriggerTarget.OpenForHigherTriggerBack = false;

        //CrawlerTarget
        CrawlerTarget.OpenForBreech = false;
        CrawlerTarget.OpenForRevolver = false;
        CrawlerTarget.OpenForBreechBack = false;

        //BreechTarget
        BreechTarget.OpenForRevolver = false;
    }

    public static void ApplyStartOptions()
    {
        HigherTriggerTarget.CanClick = true;
        HigherTriggerTarget.IsClick = false;

        RevolverTarget.ZRotateRevolver = 0;
        TriggerTarget.CanClick = false;
        TriggerTarget.CanMove = false;
        TriggerTarget.FirstTimeRevolverAndDog = false;
        TriggerTarget.FirstTimeCrawler = false;
        DogTarget.MinVal = 2.2f;

        MakeIsNotMove();
        MakeStatusOpenFalse();
        MakeOffsetZero();
    }

    public static void MakeOffsetZero()
    {
        HigherTriggerTarget.Offset = 0;
        HigherTriggerTarget.AdditionalOffset = 0;

        TriggerTarget.Offset = 0;
        TriggerTarget.AdditionalOffset = 0;

        DogTarget.Offset = 0;

        RevolverTarget.Offset = 0;
        RevolverTarget.AdditionalOffset = 0;

        CrawlerTarget.Offset = 0;

        BreechTarget.Offset = 0;

        LinkTarget.Offset = 0;
        LinkTarget.AdditionalOffset = 0;

        FirstBulletScript.Offset = 0;
        SecondBulletScript.Offset = 0;
        ThirdBulletScript.Offset = 0;
        FourthBulletScript.Offset = 0;
        FifthBulletScript.Offset = 0;
        SixthBulletScript.Offset = 0;
        SeventhBulletScript.Offset = 0;

        AllModel.Offset = 0;
    }

    public static float CalculateZRotateRevolver()
    {
        if (bulletCounter <= 6)
        {
            bulletCounter++;
        }
        return -52f * bulletCounter;
    }
}
