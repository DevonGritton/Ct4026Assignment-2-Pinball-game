using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purpleBuff : MonoBehaviour
{
    private bool collided = false;
    private void OnTriggerStay(Collider other)
    {
        collided = true;
        if (other.tag == "Ball" && collided == true)
        {
            other.gameObject.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            Destroy(gameObject);
            collided = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        collided = false;
    }

}
