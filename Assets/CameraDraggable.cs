using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDraggable : MonoBehaviour
{

    public SpriteRenderer background;

    private Bounds bounds;
    private Vector2 camBounds;
    private Camera cam;

    private Vector3 location;
    private Vector3 destination;
    private float lerpSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        if (!background)
            Debug.LogError("CameraDraggable : No background provided!");

        bounds = background.bounds;
        location = transform.position;
        destination = location;
        cam = GetComponent<Camera>();

        camBounds.x = cam.orthographicSize * (Screen.width / Screen.height);
        camBounds.y = cam.orthographicSize;
    }

    private void FixedUpdate()
    {
        Vector3 proxyPos = location;
        proxyPos.x = Mathf.Lerp(proxyPos.x, destination.x, lerpSpeed);
        proxyPos.y = Mathf.Lerp(proxyPos.y, destination.y, lerpSpeed);
        location = proxyPos;
        transform.position = location;
    }

    public void moveCamera(Vector3 movement)
    {
        Vector3 pD = destination;
        float x = Mathf.Clamp(pD.x + movement.x, bounds.min.x + camBounds.x, bounds.max.x - camBounds.x);
        float y = Mathf.Clamp(pD.y + movement.y, bounds.min.y + camBounds.y, bounds.max.y - camBounds.y);
        destination = new Vector3(x, y, pD.z);
    }

    public void testMove()
    {
        Vector3 ran = new Vector3(Random.value * 100, Random.value * 100, destination.z);
        moveCamera(ran);
    }

}
