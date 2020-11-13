using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraEffect : MonoBehaviour
{
    private Material m_Material;

    // Start is called before the first frame update
    void Awake()
    {
        m_Material = new Material(Shader.Find("Hidden/Red"));
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, null, m_Material);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
