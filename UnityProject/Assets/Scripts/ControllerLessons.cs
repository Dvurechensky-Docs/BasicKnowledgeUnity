/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:04
 * Version: 1.0.238
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
