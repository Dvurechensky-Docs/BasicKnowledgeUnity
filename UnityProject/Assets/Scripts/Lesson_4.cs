﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 сентября 2025 10:09:57
 * Version: 1.0.18
 */

using UnityEngine;

/*
 * Отслеживание нажатий от пользователя
 */
public class Lesson_4 : MonoBehaviour
{
    public GameObject TransformObj;
    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;

    private void FixedUpdate()
    {
        if(TransformObj == null) return;
        if (Input.GetKey(KeyCode.UpArrow))
            TransformObj.transform.Translate(Vector3.forward
                                           * moveSpeed);
        if (Input.GetKey(KeyCode.DownArrow))
            TransformObj.transform.Translate(-Vector3.forward
                                           * moveSpeed);
        if (Input.GetKey(KeyCode.LeftArrow))
            TransformObj.transform.Rotate(Vector3.up, -turnSpeed);
        if (Input.GetKey(KeyCode.RightArrow))
            TransformObj.transform.Rotate(Vector3.up, turnSpeed);
    }
}
