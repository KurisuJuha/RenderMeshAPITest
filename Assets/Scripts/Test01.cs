using UnityEngine;

public class Test01 : MonoBehaviour
{
    [SerializeField] private Mesh mesh;
    [SerializeField] private Material material;
    private RenderParams renderParams;

    private void Start()
    {
        renderParams = new RenderParams(material);
    }

    private void Update()
    {
        Graphics.RenderMesh(
            renderParams,
            mesh,
            0,
            Matrix4x4.Translate(new Vector3(0, 0, 0))
        );
    }
}