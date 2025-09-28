﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 28 сентября 2025 21:14:12
 * Version: 1.0.41
 */

using UnityEngine;

/*
 * Создаёт объект для Lesson_8
 * События OnCollision и OnTrigger 
 * проявляющееся на объекте Cube 
 * после соприкосновения с Wall
 */
public class Lesson_7 : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Cilinder;
    [HideInInspector]
    public GameObject CloneObj;

    private void Start()
    {
        Instantiate(Cube, Vector3.zero, Quaternion.identity);
        CloneObj = Instantiate(Cilinder, new Vector3(0, 7f), Quaternion.identity);
        Cube.SetActive(true);
        Cilinder.SetActive(true);
    }
}
