using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeBehavoiurr : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float _speed;
    private static GameObject _cam;

    void Start()
    {
       if (!_cam) _cam = GameObject.Find("Main Camera");

     }


    private void OnMouseDown()
    {
        Destroy(transform.gameObject);
    }   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back *_speed * Time.deltaTime);
        transform.rotation =_cam.transform.rotation;
    }
}
