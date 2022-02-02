using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_controller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject one_bullet_prefab;
    [SerializeField] GameObject two_bullet_prefab;
    [SerializeField] GameObject three_bullet_prefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            spawn_bullet(one_bullet_prefab);
        };

        if (Input.GetKeyDown(KeyCode.K))
        {
            spawn_bullet(two_bullet_prefab);

        };

        if (Input.GetKeyDown(KeyCode.L))
        {
            spawn_bullet(three_bullet_prefab);
        };
    }
    
    private void spawn_bullet(GameObject bullets)
    {
        Instantiate(bullets, transform);
    }

}
