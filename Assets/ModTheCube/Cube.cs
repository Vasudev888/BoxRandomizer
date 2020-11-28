using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private void Awake()
    {
        InvokeRepeating("ChangeCubeColour", 2.0f, 3.0f);
        InvokeRepeating("RandomCubeMovement", 2.0f, 3.0f);
    }

    void Start()
    {
        RandomCubeMovement();
        ChangeCubeColour();
    }
    
    void Update()
    {
        /*transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);*/

        transform.Rotate(Random.Range(20.0f * Time.deltaTime, 25.0f * Time.deltaTime), Random.Range(44.0f * Time.deltaTime, 47.0f * Time.deltaTime), Random.Range(2.0f * Time.deltaTime, 3.0f * Time.deltaTime));
        /*transform.Rotate(0 * Time.deltaTime, 0.0f, 10.0f * Time.deltaTime);*/
    }

    void RandomCubeMovement()
    {
        transform.position = new Vector3(2, Random.Range(3.0f, 10.0f), Random.Range(1, 3));
        transform.localScale = Vector3.one * Random.Range(1.0f, 4.0f);
    }

    void ChangeCubeColour()
    {
        Material material = Renderer.material;

        material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); //new Color(Random.Range(2.0f, 20.0f), 4.3f, 0.3f);
    }
}
