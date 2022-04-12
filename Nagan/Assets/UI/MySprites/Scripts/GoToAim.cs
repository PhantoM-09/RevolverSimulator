using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToAim : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject additionalCamera;
    public GameObject panelWithResult;

    public GameObject rightMenu;
    public GameObject LowMenu;
    public GameObject questionButton;
    public GameObject infoAboutGame;
    private void Start()
    {
        infoAboutGame.SetActive(false);
    }

    private void Update()
    {
        
    }

    public void SwithToMainCamera()
    {
        WriteInTable();
        HelperWithGame.OpenForAim = false;
        mainCamera.SetActive(true);
        additionalCamera.SetActive(false);
        panelWithResult.SetActive(false);

        LowMenu.SetActive(true);
        rightMenu.SetActive(true);
        questionButton.SetActive(true);
        infoAboutGame.SetActive(false);
    }

    public void SwitchToAdditionalCamera()
    {
        LowMenu.SetActive(false);
        rightMenu.SetActive(false);
        infoAboutGame.SetActive(true);
        questionButton.SetActive(false);
        HelperWithGame.OpenForAim = true;
        additionalCamera.SetActive(true);
        mainCamera.SetActive(false);
        Cursor.visible = false;


    }

    public Text All;
    public Text Good;
    public Text Bad;
    public Text Sum;

    public Text FirstNumber;
    public Text FirstAll;
    public Text FirstGood;
    public Text FirstBad;
    public Text FirstSum;

    public Text SecondNumber;
    public Text SecondAll;
    public Text SecondGood;
    public Text SecondBad;
    public Text SecondSum;

    public Text ThirdNumber;
    public Text ThirdAll;
    public Text ThirdGood;
    public Text ThirdBad;
    public Text ThirdSum;

    public Text FourthNumber;
    public Text FourthAll;
    public Text FourthGood;
    public Text FourthBad;
    public Text FourthSum;

    public Text FifthNumber;
    public Text FifthAll;
    public Text FifthGood;
    public Text FifthBad;
    public Text FifthSum;

    private int countOfRecords = 1;
    public void WriteInTable()
    {
        if(countOfRecords <=5)
        {
            Write();
        }
        else
        {
            CleanTable();
            Write();
        }
        
    }

    public void Write()
    {
        switch (countOfRecords)
        {
            case 1:
                FirstNumber.text = 1.ToString();
                FirstAll.text = All.text;
                FirstGood.text = Good.text;
                FirstBad.text = Bad.text;
                FirstSum.text = Sum.text;
                countOfRecords++;
                break;
            case 2:
                SecondNumber.text = 2.ToString();
                SecondAll.text = All.text;
                SecondGood.text = Good.text;
                SecondBad.text = Bad.text;
                SecondSum.text = Sum.text;
                countOfRecords++;
                break;
            case 3:
                ThirdNumber.text = 3.ToString();
                ThirdAll.text = All.text;
                ThirdGood.text = Good.text;
                ThirdBad.text = Bad.text;
                ThirdSum.text = Sum.text;
                countOfRecords++;
                break;
            case 4:
                FourthNumber.text = 4.ToString();
                FourthAll.text = All.text;
                FourthGood.text = Good.text;
                FourthBad.text = Bad.text;
                FourthSum.text = Sum.text;
                countOfRecords++;
                break;
            case 5:
                FifthNumber.text = 5.ToString();
                FifthAll.text = All.text;
                FifthGood.text = Good.text;
                FifthBad.text = Bad.text;
                FifthSum.text = Sum.text;
                countOfRecords++;
                break;
        }
    }

    public void CleanTable()
    {
        FirstNumber.text = 0.ToString();
        FirstAll.text = 0.ToString();
        FirstGood.text = 0.ToString();
        FirstBad.text = 0.ToString();
        FirstSum.text = 0.ToString();

        SecondNumber.text = 0.ToString();
        SecondAll.text = 0.ToString();
        SecondGood.text = 0.ToString();
        SecondBad.text = 0.ToString();
        SecondSum.text = 0.ToString();

        ThirdNumber.text = 0.ToString();
        ThirdAll.text = 0.ToString();
        ThirdGood.text =0.ToString();
        ThirdBad.text = 0.ToString();
        ThirdSum.text = 0.ToString();

        FourthNumber.text = 0.ToString();
        FourthAll.text = 0.ToString();
        FourthGood.text =0.ToString();;
        FourthBad.text = 0.ToString();
        FourthSum.text = 0.ToString();

        FifthNumber.text = 0.ToString();
        FifthAll.text = 0.ToString();
        FifthGood.text =0.ToString();;
        FifthBad.text = 0.ToString();
        FifthSum.text = 0.ToString();

        countOfRecords = 1;
    }
}
