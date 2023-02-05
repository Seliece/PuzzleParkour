using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region vars
    [Range (1, 100)]
    public int speed = 20;
    #endregion
    void Start()
    {
        transform.position = new(0, 0);
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement() {
        Vector3 direction = new();
        direction.x = (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0);
        direction.y = (Input.GetKey(KeyCode.W) ? 1 : 0) + (Input.GetKey(KeyCode.S) ? -1 : 0);

        transform.Translate((direction.normalized * speed / 100));
    }
}
