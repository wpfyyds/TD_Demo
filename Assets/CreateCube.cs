using UnityEngine;
using UnityGameFramework.Runtime;

public class CreateCube : MonoBehaviour
{
    void Awake()
    {
        // 如果当前物体不是Text物体，只执行挂载逻辑
        if (gameObject.name != "Text")
        {
            // 查找或创建名为"Text"的物体
            GameObject textObject = GameObject.Find("Text");
            if (textObject == null)
            {
                textObject = new GameObject("Text");
            }
            
            // 将脚本挂载到Text物体上
            CreateCube existingScript = textObject.GetComponent<CreateCube>();
            if (existingScript == null)
            {
                textObject.AddComponent<CreateCube>();
            }
            
            // 当前物体不需要执行生成逻辑
            return;
        }
        
        // Text物体执行生成逻辑
        StartCoroutine(GenerateCube());
    }
    
    System.Collections.IEnumerator GenerateCube()
    {
        // 等待一帧，确保脚本挂载完成
        yield return null;
        
        // 创建立方体
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "MyCube";
        cube.transform.position = new Vector3(0, 0, 0);
        cube.transform.localScale = new Vector3(1, 1, 1);
        
        Renderer renderer = cube.GetComponent<Renderer>();
        renderer.material.color = Color.blue;
        
        // 使用Unity的日志系统输出
        Debug.Log("安装成功");
    }
}