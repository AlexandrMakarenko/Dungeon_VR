using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollScript : MonoBehaviour
{
    public List<Rigidbody> ragdollElements;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //если что-то, то включаем регдолл
        //EnablePhysics();
    }

    public void EnablePhysics()
    {
        for (int i = 0; i < ragdollElements.Count; i++)
        {
            ragdollElements[i].isKinematic = false;
        }
    }
    public void DisablePhysics()
    {
        for (int i = 0; i < ragdollElements.Count; i++)
        {
            ragdollElements[i].isKinematic = true;
        }
    }
}
