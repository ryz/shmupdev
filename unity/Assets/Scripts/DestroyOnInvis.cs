using UnityEngine;
using System.Collections;

public class DestroyOnInvis : MonoBehaviour
{
    public GameObject destroyTarget = null;

    void OnBecameInvisible()
    {
        if (destroyTarget == null)
        {
            Destroy(gameObject);
        }
            
    }
}