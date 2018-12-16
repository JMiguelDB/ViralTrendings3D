using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Highlighted : MonoBehaviour
{
    Material m_Material;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        { 
            if (hit.transform.gameObject == gameObject)
            {
                try
                {
                    m_Material = GetComponent<Renderer>().material;
                    m_Material.shader = Shader.Find("Outlined/Uniform");
                }
                catch
                {
                    Renderer[] renderers = GetComponentsInChildren<Renderer>();
                    foreach (var r in renderers)
                    {
                        r.material.shader = Shader.Find("Outlined/Uniform");
                    }
                }
            }
            else
            {
                try
                {
                    m_Material = GetComponent<Renderer>().material;
                    m_Material.shader = Shader.Find("Standard");
                }
                catch
                {
                    Renderer[] renderers = GetComponentsInChildren<Renderer>();
                    foreach (var r in renderers)
                    {
                        r.material.shader = Shader.Find("Standard");
                    }
                }
            }
        }
    }
}
