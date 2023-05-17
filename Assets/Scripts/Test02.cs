using UnityEngine;

public class Test02 : MonoBehaviour
{
    [SerializeField] private Mesh mesh;
    [SerializeField] private Material material;
    private Matrix4x4[] instData;
    private RenderParams renderParams;

    private void Start()
    {
        renderParams = new RenderParams(material);
        instData = new Matrix4x4[1000];

        for (var i = 0; i < 1000; i++) instData[i] = Matrix4x4.Translate(new Vector3(i, 0, 0));
    }

    private void Update()
    {
        Graphics.RenderMeshInstanced(in renderParams, mesh, 0, instData);
    }
}