using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScriptForAdditionalCamera : MonoBehaviour
{

    public float MoveSpeed = 0.6f;
    public float RotateSpeed = 0.9f;

    public float headMinY = -40f; // ограничение угла для головы
    public float headMaxY = 40f;
    private float rotationY;
    float h;
    float v;
    float sensitivity;

    private void Start()
    {

    }

    private void Update()
    {

        //float h = Input.GetAxis("Mouse X");

        //transform.Rotate(0f, h * RotateSpeed, 0f);

        ////float v = Input.GetAxis("Mouse Y");

        ////transform.Rotate(-v * RotateSpeed, 0f, 0f);

        //float v = Input.GetAxis("Mouse Y");
        //if (v != 0)
        //{
        //    float stvol_angle =
        //    Mathf.Clamp(gameObject.transform.transform.localEulerAngles.y, min, max);

        //    gameObject.transform.localEulerAngles = new Vector3(stvol_angle, 0f, 0f);

        //    gameObject.transform.transform.Rotate(-v * RotateSpeed, 0f, 0f);
        //}
        sensitivity = 2;
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        // управление головой (камерой)
        float rotationX = gameObject.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        rotationY += Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = Mathf.Clamp(rotationY, headMinY, headMaxY);
        gameObject.transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
