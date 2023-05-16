using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.LowLevel;

public class TransportTrigger : MonoBehaviour
{

    private void OnTriggerStay(Collider Other)
    {
        if (Other.gameObject == PlayerInstance.Instance.gameObject)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("hi");
            }
        }
    }

}
