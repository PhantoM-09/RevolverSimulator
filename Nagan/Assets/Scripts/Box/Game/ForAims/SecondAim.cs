using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondAim : MonoBehaviour
{
    public GameObject aim;

    private int _cost = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bullet7" || other.gameObject.name == "Bullet6" || other.gameObject.name == "Bullet5" || other.gameObject.name == "Bullet4" || other.gameObject.name == "Bullet3" || other.gameObject.name == "Bullet4" || other.gameObject.name == "Bullet1")
        {
            aim.SetActive(false);

            HelperWithGame.ResultOfGame += 5;
            HelperWithGame.HittingBullets++;
        }

    }

    public void ShowElement()
    {
        aim.SetActive(true);
    }
}
