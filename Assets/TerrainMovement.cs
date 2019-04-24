using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TerrainMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = Vector3.zero;
        //GetComponent<Rigidbody>().MovePosition(Vector3.zero);
        MoveByDoTween();

    }

    private void MoveByDoTween()
    {
        GetComponent<Rigidbody>().DOMove(Vector3.zero, 1);
    }

    //private void MoveNormally()
    //{

    //}

    //private IEnumerator Move(Vector3 targetPosition, float duration)
    //{
    //    while (duration > 0)
    //    {
    //        GetComponent<Rigidbody>().MovePosition()
    //    }
    //}


}
