using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatsumotomGeneretor : MonoBehaviour
{
    // Start is called before the first frame  update

    public GameObject matsumotomPrefab;
    float span = 3.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(matsumotomPrefab) as GameObject;
            int px = Random.Range(-15, 65);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
