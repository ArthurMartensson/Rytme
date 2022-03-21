using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treff : MonoBehaviour
{
    public List<Transform> kuler;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Transform nærmeste = kuler[0];
            foreach (Transform kule in kuler)
            {
                if (Vector3.Distance(transform.position, kule.position)
                    < Vector3.Distance(transform.position, nærmeste.position))
                {
                    nærmeste = kule;
                }
            }
            nærmeste.Translate(20, 0, 0);
        }
    }
}
