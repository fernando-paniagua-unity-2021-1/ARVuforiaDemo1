using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    bool motorArrancado = false;
    public float speed;
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.transform.gameObject.CompareTag("F1"))
                {
                    motorArrancado = true;
                }
            }
        }
        if (motorArrancado)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
