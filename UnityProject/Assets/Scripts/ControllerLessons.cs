/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 июля 2026 07:13:25
 * Version: 1.0.319
 */

using UnityEngine;

public class ControllerLessons : MonoBehaviour
{
    private static ControllerLessons instance;
    public static ControllerLessons Instance
    {
        get
        {
            if(instance == null)
                instance = FindObjectOfType<ControllerLessons>();
            return instance;
        }
    }

    public Lesson_7 Lesson_7;
    public Lesson_3 Lesson_3;
}
