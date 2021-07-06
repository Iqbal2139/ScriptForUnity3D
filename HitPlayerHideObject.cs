using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayerHideObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" || other.tag == "Visitor")
        gameObject.SetActive(false);
    }
}
