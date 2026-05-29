/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 мая 2026 13:53:59
 * Version: 1.0.285
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
