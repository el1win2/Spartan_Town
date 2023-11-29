using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    public GameObject Caracter;
    Transform CaracterPosition;
    void Start()
    {
        CaracterPosition = Caracter.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(CaracterPosition.position.x, CaracterPosition.position.y, transform.position.z);
    }
}
