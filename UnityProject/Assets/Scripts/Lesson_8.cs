/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 29 августа 2025 06:51:51
 * Version: 1.0.11
 */

using UnityEngine;
using UnityEngine.UI;

/*
 * События OnCollision и OnTrigger 
 * проявляющееся на объекте Cube 
 * после соприкосновения с Wall 
 * и GameObject.Find
 */
public class Lesson_8 : MonoBehaviour
{
    public GameObject instObj;
    private int count = 0;
    [SerializeField]
    private float speed = 4f;
    private Text text;
    private float ZPos = .0f;

    private void Awake()
    {
        text = GameObject.Find("Text").GetComponent<Text>();
    }

    private void OnTriggerEnter(Collider other)
    {
        text.text = $"{other.gameObject.name}  {count++}";
    }

    private void Update()
    {
        ZPos = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        instObj.transform.Translate(Vector3.forward * speed * ZPos);
    }
}
