using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptForShowInfoElements : MonoBehaviour
{
    [SerializeField]
    public GameObject panelWithInfo;

    [SerializeField]
    public Text textField;

    private void Start()
    {
        panelWithInfo.SetActive(false);
    }

    public void ShowInfoElement()
    {
        switch (gameObject.name)
        {
            case "FrameButton":
                textField.text = "<color=red>Рама.</color> Деталь, к которой крепятся все остальные узлы и детали.";
                panelWithInfo.SetActive(true);
                break;

            case "RevolverButton":
                textField.text = "<color=red>Барабан.</color> Выполняет функции магазина и патронника.";
                panelWithInfo.SetActive(true);
                break;

            case "WoodButton":
                textField.text = "<color=red>Деревянные накладки.</color> Накрывают рукоять с боков, слегка расширяя площадь соприкосновения с ладонью и увеличивая сцепление с кожей благодаря своей структуре.";
                panelWithInfo.SetActive(true);
                break;

            case "RamrodButton":
                textField.text = "<color=red>Шомпол.</color> Предназначен для удаления стреляных гильз.";
                panelWithInfo.SetActive(true);
                break;

            case "ShellButton":
                textField.text = "<color=red>Гильза.</color> Предназначена для для помещения метательного заряда и средств воспламенения.";
                panelWithInfo.SetActive(true);
                break;

            case "BulletButton":
                textField.text = "<color=red>Пуля.</color>";
                panelWithInfo.SetActive(true);
                break;

            case "DoorButton":
                textField.text = "<color=red>Дверца.</color> При открывании отключает курок и позволяет использовать спусковой крючок для проворачивания барабана при заряжании.";
                panelWithInfo.SetActive(true);
                break;

            case "SpringButton":
                textField.text = "<color=red>Боевая пружина.</color> Служит для приведения в действие курка.";
                panelWithInfo.SetActive(true);
                break;

            case "HigherTriggerButton":
                textField.text = "<color=red>Курок.</color> Предназначен для нанесения удара по капсюлю патрона.";
                panelWithInfo.SetActive(true);
                break;

            case "TriggerButton":
                textField.text = "<color=red>Спусковой крючок.</color> Освобождает курок и приводит к выстрелу.";
                panelWithInfo.SetActive(true);
                break;

            case "DogButton":
                textField.text = "<color=red>Собачка.</color> Предназначена для прокрутки барабана.";
                panelWithInfo.SetActive(true);
                break;

            case "CrawlerButton":
                textField.text = "<color=red>Ползун.</color> Предназначен для поднятия казенника.";
                panelWithInfo.SetActive(true);
                break;

            case "BreechButton":
                textField.text = "<color=red>Казенник.</color> Толкает барабан вперед, помещая часть гильзы в ствол.";
                panelWithInfo.SetActive(true);
                break;

            case "LinkButton":
                textField.text = "<color=red>Шатун.</color> Служит для возвращения ползуна.";
                panelWithInfo.SetActive(true);
                break;
        }
    }

    public void HideInfoElement()
    {
        panelWithInfo.SetActive(false);
    }
}
