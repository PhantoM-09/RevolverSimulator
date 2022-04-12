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
                textField.text = "<color=red>����.</color> ������, � ������� �������� ��� ��������� ���� � ������.";
                panelWithInfo.SetActive(true);
                break;

            case "RevolverButton":
                textField.text = "<color=red>�������.</color> ��������� ������� �������� � ����������.";
                panelWithInfo.SetActive(true);
                break;

            case "WoodButton":
                textField.text = "<color=red>���������� ��������.</color> ��������� ������� � �����, ������ �������� ������� ��������������� � ������� � ���������� ��������� � ����� ��������� ����� ���������.";
                panelWithInfo.SetActive(true);
                break;

            case "RamrodButton":
                textField.text = "<color=red>������.</color> ������������ ��� �������� ��������� �����.";
                panelWithInfo.SetActive(true);
                break;

            case "ShellButton":
                textField.text = "<color=red>������.</color> ������������� ��� ��� ��������� ������������ ������ � ������� �������������.";
                panelWithInfo.SetActive(true);
                break;

            case "BulletButton":
                textField.text = "<color=red>����.</color>";
                panelWithInfo.SetActive(true);
                break;

            case "DoorButton":
                textField.text = "<color=red>������.</color> ��� ���������� ��������� ����� � ��������� ������������ ��������� ������ ��� �������������� �������� ��� ���������.";
                panelWithInfo.SetActive(true);
                break;

            case "SpringButton":
                textField.text = "<color=red>������ �������.</color> ������ ��� ���������� � �������� �����.";
                panelWithInfo.SetActive(true);
                break;

            case "HigherTriggerButton":
                textField.text = "<color=red>�����.</color> ������������ ��� ��������� ����� �� ������� �������.";
                panelWithInfo.SetActive(true);
                break;

            case "TriggerButton":
                textField.text = "<color=red>��������� ������.</color> ����������� ����� � �������� � ��������.";
                panelWithInfo.SetActive(true);
                break;

            case "DogButton":
                textField.text = "<color=red>�������.</color> ������������� ��� ��������� ��������.";
                panelWithInfo.SetActive(true);
                break;

            case "CrawlerButton":
                textField.text = "<color=red>������.</color> ������������ ��� �������� ���������.";
                panelWithInfo.SetActive(true);
                break;

            case "BreechButton":
                textField.text = "<color=red>��������.</color> ������� ������� ������, ������� ����� ������ � �����.";
                panelWithInfo.SetActive(true);
                break;

            case "LinkButton":
                textField.text = "<color=red>�����.</color> ������ ��� ����������� �������.";
                panelWithInfo.SetActive(true);
                break;
        }
    }

    public void HideInfoElement()
    {
        panelWithInfo.SetActive(false);
    }
}
