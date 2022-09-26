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

    void InitialiseList()
    {
        gridPositions.Clear();

        for (int x = 0; x < columns - 1; x++)
        {
            for (int y = 0; y < rows - 1; y++)
            {
                gridPositions.Add(new Vector3(x, y, 0));
            }
        }
    }

    void BoardSetup()
    {
        boardHolder = new GameObject("Board").transform;

        for (int x = -1; x < columns + 1; x++)
        {
            for (int y = -1; y < rows + 1; y++)
            {
                GameObject toInstantiate = floorTiles[Random.Range(0, floorTiles.Length)];

                if (x == -1 || x == columns || y == -1 || y == rows)
                {
                    toInstantiate = outerWallTiles[Random.Range(0, wallTiles.Length)];
                }

                GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);
            }
        }
    }

    Vector3 RandomPosition()
    {
        int randomIndex = Random.Range(0, gridPositions.Count);
        Vector3 randomPosition = gridPositions[randomIndex];
        gridPositions.RemoveAt(randomIndex);
        return randomPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
