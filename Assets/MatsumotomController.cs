using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatsumotomController : MonoBehaviour
{
    // Start is called before the first frame update
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    Rigidbody2D rigid2D;
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
        //松本は一定方向に歩く
            this.rigid2D.AddForce(transform.right* -1 * this.walkForce);
        }
        //松本が落ちたら破棄
        if (transform.position.y < -13.0f)
        {
            Destroy(gameObject);
        }

        
    }
}
