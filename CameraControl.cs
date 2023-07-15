using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrolakamere : MonoBehaviour
{
   [SerializeField] private Transform square;
    
   private void Update()
    {
        transform.position= new Vector3(square.position.x, square.position.y, transform.position.z);
    }
}
