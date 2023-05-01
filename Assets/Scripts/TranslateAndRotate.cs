using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class TranslateAndRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector3.right);
        transform.Rotate(0f, 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
