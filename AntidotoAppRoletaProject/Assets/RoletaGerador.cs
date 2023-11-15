using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoletaGerador : MonoBehaviour
{
     public int quantidadeDeFatias = 8;

    void Update()
    {
        CriarCirculoDividido(quantidadeDeFatias);
    }

    void CriarCirculoDividido(int fatias)
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        Vector3[] vertices = new Vector3[fatias * 3];
        int[] tri = new int[fatias * 3];

        float anguloPorFatia = 360f / fatias;

        for (int i = 0; i < fatias; i++)
        {
            float radianos = Mathf.Deg2Rad * (i * anguloPorFatia);

            // Vértice central
            vertices[i * 3] = Vector3.zero;

            // Vértice na borda do círculo
            vertices[i * 3 + 1] = new Vector3(Mathf.Cos(radianos), 0f, Mathf.Sin(radianos));

            // Vértice na borda do próximo triângulo
            vertices[i * 3 + 2] = new Vector3(Mathf.Cos(radianos + Mathf.Deg2Rad * anguloPorFatia), 0f, Mathf.Sin(radianos + Mathf.Deg2Rad * anguloPorFatia));

            // Índices dos vértices
            tri[i * 3] = i * 3;
            tri[i * 3 + 1] = i * 3 + 1;
            tri[i * 3 + 2] = i * 3 + 2;
        }

        mesh.vertices = vertices;
        mesh.triangles = tri;

        mesh.RecalculateNormals();
    }
}
