using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 direction = new Vector3(0f, 1f, 0f);
    [SerializeField] float speed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    private void Moving()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
