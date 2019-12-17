using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererController : MonoBehaviour
{
    public LineRenderer LineRenderer;

    public Transform[] Links;

    void Start()
    {
        LineRenderer.positionCount = Links.Length;

        for (int i = 0; i < Links.Length; i++)
        {
            LineRenderer.SetPosition(i, Links[i].position);
        }
    }

    void Update()
    {
        for (int i = 0; i < Links.Length; i++)
        {
            LineRenderer.SetPosition(i, Links[i].position);
        }
    }
}
