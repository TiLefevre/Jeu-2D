using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{

    public float vie;
    private float height;
    public GameObject barre;
    public GameObject cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float vie2 = vie/200;

        barre.transform.localScale = new Vector3(vie2, 0.05f, 1);
        barre.transform.position = cam.transform.position + new Vector3((-10f + (vie2* 9.6f))-5f, -8f, 3f);

    }
}