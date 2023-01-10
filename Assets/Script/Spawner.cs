using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private Transform _objectToSpawn;
    [SerializeField] private float distanceToCam = 10f;
    [SerializeField] private int _limitObject;
    [SerializeField] private float radius = 5f;
    [SerializeField] private float spawnSpeed = 1f;
    [SerializeField] private float _distanceMax;

    [SerializeField] private float _distanceMin;

    private int _numberObject;
    private Transform _firstListObject;
    private List<Transform> _myGameObject = new List<Transform>();

    private float time = 0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time >= 1f / spawnSpeed)
        {

            // On récupère l'objet qu'on fait apparaitre

            SpawnNewObject();

            time = 0f;
        }

    }

    private void SpawnNewObject()
    {
        float randomDistance = Random.Range(_distanceMin, _distanceMax);

        Vector3 positionObjectToSpawn = Camera.main.ScreenToWorldPoint(
            new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), randomDistance));
        Instantiate(_objectToSpawn, positionObjectToSpawn, Quaternion.identity);
    }

  
}
