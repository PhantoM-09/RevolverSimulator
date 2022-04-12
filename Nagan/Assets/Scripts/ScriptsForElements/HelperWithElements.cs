using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.ScriptsForElements
{
    public static class HelperWithElements
    {
        private static float _speed = 0.06f;
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
            HigherTriggerScript.IsMove = true;
            TriggerScript.IsMove = true;
            DogScript.IsMove = true;
            CrawlerScript.IsMove = true;
            RevolverScript.IsMove = true;
            BreechScript.IsMove = true;

        }

        public static void MakeIsNotMove()
        {
            HigherTriggerScript.IsMove = false;
            TriggerScript.IsMove = false;
            DogScript.IsMove = false;
            CrawlerScript.IsMove = false;
            RevolverScript.IsMove = false;
            BreechScript.IsMove = false;
        }

        public static void MakeStatusOpenFalse()
        {
            //HigherTriggerScript
            
            HigherTriggerScript.OpenForTrigger = false;
            HigherTriggerScript.OpenForFirstBullet = false;
            HigherTriggerScript.OpenForSecondBullet = false;
            HigherTriggerScript.OpenForThirdBullet = false;
            HigherTriggerScript.OpenForFourthBullet = false;
            HigherTriggerScript.OpenForFifthBullet = false;
            HigherTriggerScript.OpenForSixthBullet = false;
            HigherTriggerScript.OpenForSeventhBullet = false;
            HigherTriggerScript.OpenForTriggerBack = false;
            HigherTriggerScript.OpenForDogBack = false;

            //TriggrScript
            TriggerScript.OpenForDog = false;
            TriggerScript.OpenForRevolver = false;
            TriggerScript.OpenForCrawler = false;
            TriggerScript.OpenForHigherTrigger = false;
            TriggerScript.OpenForLinkForward = false;
            TriggerScript.OpenForLinkBack = false;
            TriggerScript.OpenForHigherTriggerBack = false;

            //CrawlerScript
            CrawlerScript.OpenForBreech = false;
            CrawlerScript.OpenForRevolver = false;
            CrawlerScript.OpenForBreechBack = false;

            //BreechScript
            BreechScript.OpenForRevolver = false;

            
        }

        public static void ApplyStartOptions()
        {
            HigherTriggerScript.CanClick = true;
            HigherTriggerScript.IsClick = false;

            RevolverScript.ZRotateRevolver = 0;
            TriggerScript.CanClick = false;
            TriggerScript.CanMove = false;
            TriggerScript.FirstTimeRevolverAndDog = false;
            TriggerScript.FirstTimeCrawler = false;
            DogScript.MinVal = 2.2f;

            MakeIsNotMove();
            MakeStatusOpenFalse();
            MakeOffsetZero();
        }

        public static void MakeOffsetZero()
        {
            HigherTriggerScript.Offset = 0;
            HigherTriggerScript.AdditionalOffset = 0;

            TriggerScript.Offset = 0;
            TriggerScript.AdditionalOffset = 0;

            DogScript.Offset = 0;

            RevolverScript.Offset = 0;
            RevolverScript.AdditionalOffset = 0;

            CrawlerScript.Offset = 0;

            BreechScript.Offset = 0;

            LinkScript.Offset = 0;
            LinkScript.AdditionalOffset = 0;

            FirstBulletScript.Offset = 0;
            SecondBulletScript.Offset = 0;
            ThirdBulletScript.Offset = 0;
            FourthBulletScript.Offset = 0;
            FifthBulletScript.Offset = 0;
            SixthBulletScript.Offset = 0;
            SeventhBulletScript.Offset = 0;
        }

        public static float CalculateZRotateRevolver()
        {
            if(bulletCounter <= 6)
            {
                bulletCounter++;
            }
            return -52f * bulletCounter;
        }
    }
}
