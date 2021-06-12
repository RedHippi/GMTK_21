using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStationary : MonoBehaviour
{

    public SpriteRenderer background;

    // Start is called before the first frame update
    void Start()
    {
        Camera cam = GetComponent<Camera>();

        float widthHeight = background.bounds.extents.x * (Screen.height / Screen.width);
        float height = background.bounds.extents.y;

        cam.orthographicSize = Mathf.Max(height, widthHeight);
    }
}
