using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRInteraction : MonoBehaviour
{
    public Camera vrCamera;
    public Image cursor;

    public float actionRate = 2; // как часто срабатывает взгляд
    float nextAction;

    public float multipleCursor = 3; // на сколько увелечится курсор
    RectTransform cursorTransform; // компонент трансформации курсора
    Vector2 startCursorSize; // стартовый размер курсора

    void Start()
    {
        cursorTransform = cursor.GetComponent<RectTransform>(); // получаем компонент у курсора RectTransform
        startCursorSize = cursorTransform.sizeDelta; // сохраняем стратовый размер курсора
        nextAction = actionRate;
    }

    void Update()
    {
        Ray ray = vrCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); // Луч из центра камеры
        RaycastHit hit; // Объект с которым столкнется луч

        // Пускаем луч и проверяем объект пересечения
        if (Physics.Raycast(ray, out hit) && hit.transform.GetComponent<IVRInteractible>() 
            != null)
        {
            cursorTransform.sizeDelta += new Vector2(multipleCursor, multipleCursor) * Time.deltaTime;
            // Debug.Log(hit.collider.gameObject.name);
            if (Time.time >= nextAction)
            {
                nextAction = Time.time + actionRate;
                ClearCursor();
                hit.transform.GetComponent<IVRInteractible>().OnReady();          
            }
        }
        else
        {
            nextAction = Time.time + actionRate;
            ClearCursor();
        }

    }

    void ClearCursor()
    {
        cursorTransform.sizeDelta = startCursorSize;
    }
}
