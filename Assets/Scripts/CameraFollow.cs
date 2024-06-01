using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform[] targets;  // Массив объектов, за которыми должна следовать камера
    public Vector3 offset;       // Смещение камеры относительно средней позиции объектов

    void LateUpdate()
    {
        if (targets.Length == 0)
            return;

        Vector3 averagePosition = CalculateAveragePosition();
        transform.position = averagePosition + offset;
    }

    Vector3 CalculateAveragePosition()
    {
        Vector3 sum = Vector3.zero;
        foreach (Transform target in targets)
        {
            sum += target.position;
        }
        return sum / targets.Length;
    }
}
