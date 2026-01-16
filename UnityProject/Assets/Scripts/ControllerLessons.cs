/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 января 2026 06:51:46
 * Version: 1.0.151
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
