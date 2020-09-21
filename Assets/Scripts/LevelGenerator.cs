using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject[] objects = new GameObject[8];
    int[,] levelMap =
        {
            {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
            {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
            {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
            {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
            {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
            {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
            {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
            {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
            {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
            {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
            {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };
    int[,] rotation =
    {
        {90,90,90,90,90,90,90,90,90,90,90,90,90,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,270,90,90,180,0,270,90,90,90,180,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,90,90,90,0,0,90,90,90,90,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,270,90,90,180,0,270,180,0,270,90,90,90},
        {0,0,0,90,90,90,0,0,0,0,0,90,90,180},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {180,90,90,90,90,0,0,0,0,90,90,180,0,0},
        {0,0,0,0,0,0,0,0,270,90,90,90,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,270,90,90,0},
        {90,90,90,90,90,270,0,0,90,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0}

    };
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < levelMap.GetLength(0); y++)
        {
            for (int x = 0; x < levelMap.GetLength(1); x++)
            {
                int level = levelMap[y, x];
                switch (level)
                {
                    case 0:
                        break;
                    case 1:
                        Instantiate(objects[0], new Vector3(x, -y), Quaternion.Euler(0, 0, rotation[y, x]));
                       
                        break;
                    case 2:
                        Instantiate(objects[1], new Vector3(x, -y), Quaternion.Euler(0, 0, rotation[y, x]));
                     
                        break;
                    case 3:
                        Instantiate(objects[2], new Vector3(x, -y), Quaternion.Euler(0, 0, rotation[y, x]));
                       
                        break;
                    case 4:
                        Instantiate(objects[3], new Vector3(x, -y), Quaternion.Euler(0, 0, rotation[y, x]));
                     
                        break;
                    case 5:
                        Instantiate(objects[4], new Vector3(x, -y), Quaternion.Euler(0, 0, rotation[y, x]));
                     
                        break;
                    case 6:
                        Instantiate(objects[5], new Vector3(x, -y), Quaternion.Euler(0, 0, rotation[y, x]));
                      
                       
                        break;
                    case 7:
                        Instantiate(objects[6], new Vector3(x, -y), Quaternion.Euler(0, 0, rotation[y, x]));
                       
    
                        break;
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
