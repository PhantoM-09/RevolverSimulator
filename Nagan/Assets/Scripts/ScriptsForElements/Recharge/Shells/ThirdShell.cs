using Assets.Scripts.ScriptsForElements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdShell : MonoBehaviour
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

    public GameObject shell;
    void Update()
    {
        if (MoveRamrod.MoveToMainPosition)
        {
            if (MoveRamrodForwardAndBack.OpenForThirdShell)
            {
                if (OffsetMoveBack < 1)
                    OffsetMoveBack += HelperWithRecharge.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, -60f), OffsetMoveBack);

                if (gameObject.transform.localPosition.z <= -60f)
                {
                    OffsetMoveBack = 0;
                    MoveRamrodForwardAndBack.OpenForThirdShell = false;
                    shell.SetActive(false);
                }
            }
        }
        else
        {
            if (RevolverRotater.OpenPutThirdShell)
            {
                
                if (OffsetMoveBack < 1)
                    OffsetMoveBack += HelperWithRecharge.Speed;

                gameObject.transform.localPosition = Vector3.Lerp(gameObject.transform.localPosition, new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 0.3574219f), OffsetMoveBack);

                if (gameObject.transform.localPosition.z >= 0.3574219f)
                {
                    OffsetMoveBack = 0;
                    RevolverRotater.OpenPutThirdShell = false;

                    RevolverRotater.PutZRotate = HelperWithRecharge.CalculatePutZRotate();
                    RevolverRotater.DeleteRotate = false;

                    MoveRamrodForwardAndBack.CanRotateRevolver = true;
                }
            }
        }
    }
}
