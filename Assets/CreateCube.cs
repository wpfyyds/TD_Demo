using UnityEngine;

public class CreateCube : MonoBehaviour
{
    void Start()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "MyCube";
        cube.transform.position = new Vector3(0, 0, 0);
        cube.transform.localScale = new Vector3(1, 1, 1);
        
        Renderer renderer = cube.GetComponent<Renderer>();
        renderer.material.color = Color.blue;
    }
}