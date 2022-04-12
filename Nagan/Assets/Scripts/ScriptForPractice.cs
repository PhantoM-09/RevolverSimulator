using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptForPractice : MonoBehaviour
{
    private static bool _canDoFirstTask = true;
    
    private static bool _openFirstTask = false;
    public static bool OpenFirstTask
    {
        get
        {
            return _openFirstTask;
        }
        set
        {
            _openFirstTask = value;
        }
    }

    private static bool _canDoSecondTask = false;

    private static bool _openSecondTask = false;
    public static bool OpenSecondTask
    {
        get
        {
            return _openSecondTask;
        }
        set
        {
            _openSecondTask = value;
        }
    }

    private static bool _canDoThirdTask = false;

    private static bool _openThirdTask = false;
    public static bool OpenThirdTask
    {
        get
        {
            return _openThirdTask;
        }
        set
        {
            _openThirdTask = value;
        }
    }

    private static bool _canDoFourthTask = false;

    private static bool _openFourthTask = false;
    public static bool OpenFourthTask
    {
        get
        {
            return _openFourthTask;
        }
        set
        {
            _openFourthTask = value;
        }
    }

    private static bool _canClean = false;

    private static bool _openClean = false;
    public static bool OpenClean
    {
        get
        {
            return _openClean;
        }
        set
        {
            _openClean = value;
        }
    }

    private static bool _canClick = true;
    public static bool CanClick
    {
        get
        {
            return _canClick;
        }
        set
        {
            _canClick = value;
        }
    }

    public Text TextField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!_canClick)
        {
            if (OpenFirstTask && _canDoFirstTask)
            {
                TextField.fontSize = 24;
                TextField.text = "1. Взведите курок";
                OpenFirstTask = false;
                _canDoFirstTask = false;

                _canDoSecondTask = true;
            }

            if (OpenSecondTask && _canDoSecondTask)
            {
                TextField.fontSize = 24;
                TextField.text = "2. Нажмите на спусковой крючок";
                OpenSecondTask = false;
                _canDoSecondTask = false;

                _canDoThirdTask = true;
            }

            if(OpenThirdTask && _canDoThirdTask)
            {
                TextField.fontSize = 24;
                TextField.text = "3. Повторите эти действия еще 6 раз";
                OpenThirdTask = false;
                _canDoThirdTask = false;

                _canDoFourthTask = true;
            }

            if(OpenFourthTask && _canDoFourthTask)
            {
                TextField.fontSize = 24;
                TextField.text = "4. Нажмите на кнопку Перезарядить";
                OpenFourthTask = false;
                _canDoFourthTask = false;

                _canClean = true;
            }
            
            if(OpenClean && _canClean)
            {
                TextField.fontSize = 14;
                TextField.text = "Работа с симулятором. Для перехода в режим <color=red>мишени</color> необходимо нажать на соответствующую кнопку. +" +
                    " После мишени появятся результаты, увидеть их можно при наведении на кнопку <color=red>таблица</color>. Для очистки таблицы используется кнопка в виде +" +
                    " <color=red>корзины</color>. Есть возможность скрывать детали нажав на кнопку <color=red>глаза</color> и выбрав режим.  Покраску установки можно поменять +" +
                    " при нажатии на кнопку <color=red>кисти</color> и выбора режима.";
                OpenClean = false;
                _canClean = false;

                CanClick = true;
                _openSecondTask = false;
                _openThirdTask = false;
                _openFourthTask = false;
            }

        }

    }

    public void StartPractice()
    {
        if(_canClick)
        {
            _openFirstTask = true;
            _canDoFirstTask = true;

            _canClick = false;
        }
    }
}
