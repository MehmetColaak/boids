using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawn : MonoBehaviour
{
    [SerializeField]
    public GameObject sphere;
    //GameObject sphere;
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
            GameObject newSphere = Instantiate(sphere);
            sphere.transform.position = Vector3.zero;
            spheresList.Add(sphere);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject sphere in spheresList)
        {
            
        }
    }
}
