using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BoardManager : MonoBehaviour
{
    [Serializable]
    public class Count
    {
        public int minimum;
        public int maximum;

        public Count(int min, int max)
        {
            minimum = min; maximum = max;
        }
    }
    [SerializeField] int columns = 8;
    [SerializeField] int rows = 8;
    [SerializeField] Count wallCount = new Count(5, 9);
    [SerializeField] Count foodCount = new Count(1, 5);
    [SerializeField] GameObject exit;
    [SerializeField] GameObject[] floorTiles;
    [SerializeField] GameObject[] wallTiles;
    [SerializeField] GameObject[] foodTiles;
    [SerializeField] GameObject[] enemyTiles;
    [SerializeField] GameObject[] outerWallTiles;

    private Transform boardHolder;
    private List <Vector3> gridPositions = new List<Vector3>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
