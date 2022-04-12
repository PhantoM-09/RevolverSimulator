using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkins : MonoBehaviour
{
    public GameObject higherTriggerMain;
    public GameObject triggerMain;
    public GameObject revolverMain;
    public GameObject leftFrameMain;
    public GameObject rightFrameMain;
    public GameObject ramrodMain;
    public GameObject doorMain;
    public GameObject leftPadMain;
    public GameObject rightPadMain;

    public GameObject higherTriggerTarget;
    public GameObject triggerTarget;
    public GameObject revolverTarget;
    public GameObject leftFrameTarget;
    public GameObject rightFrameTarget;
    public GameObject ramrodTarget;
    public GameObject doorTarget;
    public GameObject leftPadTarget;
    public GameObject rightPadTarget;

    private Material baseMaterialAll;
    private Material baseMaterialPads;

    public Material desert;
    public Material forDesertPad;
    
    public Material abstraction;
    public Material forAbstractionPad;

    public Material green;
    public Material forGreenPad;

    // Start is called before the first frame update
    void Start()
    {
        baseMaterialAll = higherTriggerMain.GetComponent<Renderer>().material;
        baseMaterialPads = leftPadMain.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeIntoBase()
    {
        higherTriggerMain.GetComponent<Renderer>().material = baseMaterialAll;
        triggerMain.GetComponent<Renderer>().material = baseMaterialAll;
        revolverMain.GetComponent<Renderer>().material = baseMaterialAll;
        leftFrameMain.GetComponent<Renderer>().material = baseMaterialAll;
        rightFrameMain.GetComponent<Renderer>().material = baseMaterialAll;
        ramrodMain.GetComponent<Renderer>().material = baseMaterialAll;
        doorMain.GetComponent<Renderer>().material = baseMaterialAll;
        leftPadMain.GetComponent<Renderer>().material = baseMaterialPads;
        rightPadMain.GetComponent<Renderer>().material = baseMaterialPads;

        higherTriggerTarget.GetComponent<Renderer>().material = baseMaterialAll;
        triggerTarget.GetComponent<Renderer>().material = baseMaterialAll;
        revolverTarget.GetComponent<Renderer>().material = baseMaterialAll;
        leftFrameTarget.GetComponent<Renderer>().material = baseMaterialAll;
        rightFrameTarget.GetComponent<Renderer>().material = baseMaterialAll;
        ramrodTarget.GetComponent<Renderer>().material = baseMaterialAll;
        doorTarget.GetComponent<Renderer>().material = baseMaterialAll;
        leftPadTarget.GetComponent<Renderer>().material = baseMaterialPads;
        rightPadTarget.GetComponent<Renderer>().material = baseMaterialPads;
    }

    public void ChangeIntoDesert()
    {
        higherTriggerMain.GetComponent<Renderer>().material = desert;
        triggerMain.GetComponent<Renderer>().material = desert;
        revolverMain.GetComponent<Renderer>().material = desert;
        leftFrameMain.GetComponent<Renderer>().material = desert;
        rightFrameMain.GetComponent<Renderer>().material = desert;
        ramrodMain.GetComponent<Renderer>().material = desert;
        doorMain.GetComponent<Renderer>().material = desert;
        leftPadMain.GetComponent<Renderer>().material = forDesertPad;
        rightPadMain.GetComponent<Renderer>().material = forDesertPad;

        higherTriggerTarget.GetComponent<Renderer>().material = desert;
        triggerTarget.GetComponent<Renderer>().material = desert;
        revolverTarget.GetComponent<Renderer>().material = desert;
        leftFrameTarget.GetComponent<Renderer>().material = desert;
        rightFrameTarget.GetComponent<Renderer>().material = desert;
        ramrodTarget.GetComponent<Renderer>().material = desert;
        doorTarget.GetComponent<Renderer>().material = desert;
        leftPadTarget.GetComponent<Renderer>().material = forDesertPad;
        rightPadTarget.GetComponent<Renderer>().material = forDesertPad;
    }

    public void ChangeIntoAbstraction()
    {
        higherTriggerMain.GetComponent<Renderer>().material = abstraction;
        triggerMain.GetComponent<Renderer>().material = abstraction;
        revolverMain.GetComponent<Renderer>().material = abstraction;
        leftFrameMain.GetComponent<Renderer>().material = abstraction;
        rightFrameMain.GetComponent<Renderer>().material = abstraction;
        ramrodMain.GetComponent<Renderer>().material = abstraction;
        doorMain.GetComponent<Renderer>().material = abstraction;
        leftPadMain.GetComponent<Renderer>().material = forAbstractionPad;
        rightPadMain.GetComponent<Renderer>().material = forAbstractionPad;

        higherTriggerTarget.GetComponent<Renderer>().material = abstraction;
        triggerTarget.GetComponent<Renderer>().material = abstraction;
        revolverTarget.GetComponent<Renderer>().material = abstraction;
        leftFrameTarget.GetComponent<Renderer>().material = abstraction;
        rightFrameTarget.GetComponent<Renderer>().material = abstraction;
        ramrodTarget.GetComponent<Renderer>().material = abstraction;
        doorTarget.GetComponent<Renderer>().material = abstraction;
        leftPadTarget.GetComponent<Renderer>().material = forAbstractionPad;
        rightPadTarget.GetComponent<Renderer>().material = forAbstractionPad;
    }

    public void ChangeIntoGreen()
    {
        higherTriggerMain.GetComponent<Renderer>().material = green;
        triggerMain.GetComponent<Renderer>().material = green;
        revolverMain.GetComponent<Renderer>().material = green;
        leftFrameMain.GetComponent<Renderer>().material = green;
        rightFrameMain.GetComponent<Renderer>().material = green;
        ramrodMain.GetComponent<Renderer>().material = green;
        doorMain.GetComponent<Renderer>().material = green;
        leftPadMain.GetComponent<Renderer>().material = forGreenPad;
        rightPadMain.GetComponent<Renderer>().material = forGreenPad;

        higherTriggerTarget.GetComponent<Renderer>().material = green;
        triggerTarget.GetComponent<Renderer>().material = green;
        revolverTarget.GetComponent<Renderer>().material = green;
        leftFrameTarget.GetComponent<Renderer>().material = green;
        rightFrameTarget.GetComponent<Renderer>().material = green;
        ramrodTarget.GetComponent<Renderer>().material = green;
        doorTarget.GetComponent<Renderer>().material = green;
        leftPadTarget.GetComponent<Renderer>().material = forGreenPad;
        rightPadTarget.GetComponent<Renderer>().material = forGreenPad;
    }
}
