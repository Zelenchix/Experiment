using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public GameObject[] staticCubes; // Массив неподвижных кубов
    private Color averageColor; // Средний цвет

    void Start()
    {
        // Инициализируем средний цвет как цвет первого неподвижного куба
        if (staticCubes.Length > 0)
        {
            averageColor = staticCubes[0].GetComponent<Renderer>().material.color;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("StaticCube") && staticCubes.Length > 0)
        {
            GameObject collidedCube = collision.gameObject;
            Color collidedColor = collidedCube.GetComponent<Renderer>().material.color;

            // Вычисляем средний цвет от двух кубов
            averageColor = (averageColor + collidedColor) / 2;

            // Присваиваем средний цвет двигающемуся кубу
            GetComponent<Renderer>().material.color = averageColor;
        }
    }
}
