using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickInfo : MonoBehaviour
{
    // public GameObject Hint;

    //  void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         RaycastHit hit;
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //         if (Physics.Raycast(ray, out hit))
    //         {
    //             MeshCollider mc = hit.collider as MeshCollider;
    //             if (mc != null)
    //             {
    //                 Hint.SetActive(true);
    //             }
    //         }
    //     }
    // }

    public GameObject Hint;
     void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Hint.SetActive(true);
    }


}
