using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new(2, 0);
    }

    public void OnMouseDrag() {
        transform.position = new(Mathf.Lerp(-8.9f, 8.9f, Input.mousePosition.x / 1920), Mathf.Lerp(-5, 5, Input.mousePosition.y / 1080));
    }
}
