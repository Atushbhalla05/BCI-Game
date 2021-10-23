using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float scrollSpeed;
    Material mat;
    Vector2 offset;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
        offset = new Vector2(scrollSpeed, 0);
    }

    void Update()
    {
        mat.mainTextureOffset += (offset * Time.deltaTime);
    }
}
