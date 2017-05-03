using System.Collections;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{

    public float tumble;
    Rigidbody rigid;


    void Start()
    {

        rigid.angularVelocity = Random.insideUnitSphere * tumble;

    }

}
