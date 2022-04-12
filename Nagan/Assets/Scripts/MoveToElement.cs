using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToElement : MonoBehaviour
{

    bool move = false;
    Vector3 startPosition;
    Vector3 needPosition;
    float speed = 0.01f;
    float offset = 0;
    Quaternion startRotation;
    Quaternion needRotaton;

    public Transform cameraEmpty;
    public Transform woodEmpty;
    public Transform ramrodEmpty;
    public Transform revolverEmpty;
    public Transform shellEmpty;
    public Transform bulletEmpty;
    public Transform doorEmpty;
    public Transform frameEmpty;
    public Transform springEmpty;
    public Transform higherTriggerEmpty;
    public Transform triggerEmpty;
    public Transform dogEmpty;
    public Transform crawlerEmpty;
    public Transform breechEmpty;
    public Transform linkEmpty;

    public GameObject leftFrame;
    public GameObject rightFrame;

    public void MoveToCameraEmpty()
    {
        ShowAll();

        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            needPosition = cameraEmpty.position;
            needRotaton = cameraEmpty.rotation;
        }

    }

    public void MoveToWoodEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            needPosition = woodEmpty.position;
            needRotaton = woodEmpty.rotation;

        }

    }

    public void MoveToRamrodEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            needPosition = ramrodEmpty.position;
            needRotaton = ramrodEmpty.rotation;

        }

    }

    public void MoveToRevolverEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            needPosition = revolverEmpty.position;
            needRotaton = revolverEmpty.rotation;

        }

    }

    public void MoveToShellEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            needPosition = shellEmpty.position;
            needRotaton = shellEmpty.rotation;

        }

    }

    public void MoveToBulletEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;


            needPosition = bulletEmpty.position;
            needRotaton = bulletEmpty.rotation;

        }

    }

    public void MoveToDoorEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            needPosition = doorEmpty.position;
            needRotaton = doorEmpty.rotation;

        }

    }

    public void MoveToFrameEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            needPosition = frameEmpty.position;
            needRotaton = frameEmpty.rotation;

        }

    }

    public void MoveToSpringEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            leftFrame.SetActive(false);

            needPosition = springEmpty.position;
            needRotaton = springEmpty.rotation;

        }

    }

    public void MoveToHigherTriggerEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            leftFrame.SetActive(false);
            rightFrame.SetActive(false);

            needPosition = higherTriggerEmpty.position;
            needRotaton = higherTriggerEmpty.rotation;

        }

    }

    public void MoveToTriggerEmpty()
    {
        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            leftFrame.SetActive(false);

            needPosition = triggerEmpty.position;
            needRotaton = triggerEmpty.rotation;

        }

    }

    public void MoveToDogEmpty()
    {

        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            leftFrame.SetActive(false);
            rightFrame.SetActive(false);

            needPosition = dogEmpty.position;
            needRotaton = dogEmpty.rotation;

        }

    }

    public void MoveToCrawlerEmpty()
    {

        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            leftFrame.SetActive(false);
            rightFrame.SetActive(false);

            needPosition = crawlerEmpty.position;
            needRotaton = crawlerEmpty.rotation;

        }

    }

    public void MoveToBreechEmpty()
    {

        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            leftFrame.SetActive(false);
            rightFrame.SetActive(false);

            needPosition = breechEmpty.position;
            needRotaton = breechEmpty.rotation;

        }

    }

    public void MoveToLinkEmpty()
    {

        ShowAll();
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;

            leftFrame.SetActive(false);

            needPosition = linkEmpty.position;
            needRotaton = linkEmpty.rotation;

        }

    }

    void FixedUpdate()
    {

        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Lerp(startRotation, needRotaton, offset);



            if (offset >= 1)
            {
                move = false;
                offset = 0;


            }


        }
    }


    public void ShowAll()
    {
        leftFrame.SetActive(true);
        rightFrame.SetActive(true);
    }
}
