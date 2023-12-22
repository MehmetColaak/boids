using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawn : MonoBehaviour
{
    [SerializeField]
    public GameObject sphere;
    //deneme
    List<GameObject> spheresList;
    public int sphereCount = 20;

    void Awake()
    {
        spheresList = new List<GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sphereCount; i++)
        {
            int sphereIndex = i + 1;
            GameObject newSphere = Instantiate(sphere);
            sphere.transform.position = Vector3.zero;
            spheresList.Add(sphere);
            newSphere.name = "Sphere_" + sphereIndex;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
