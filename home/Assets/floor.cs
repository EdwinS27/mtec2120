using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {

    public GameObject blocks;
    int floorX = 0;
    int floorY = 0;
    int floorZ = 0;

    int wallX = 0;
    int wallY = 1;
    int wallZ = 0;

    int wallRX = 19;
    int wallRY = 1;
    int wallRZ = 0;


    int wallBX = 1;
    int wallBY = 1;
    int wallBZ = 19;

    int wallFX = 1;
    int wallFY = 1;
    int wallFZ = 0;

    int roofX = 0;
    int roofY = 20;
    int roofZ = 0;

    int roofRX = 10;
    int roofRY = 30;
    int roofRZ = 0;

    // Use this for initialization
    void Start () {
        // the following code is for the floor
		for(int i = 0; i < 20; i++){
            for(int j = 0; j < 20; j++){

                Instantiate(blocks, new Vector3(floorX, floorY, floorZ), Quaternion.identity);
                floorX += 1;
            }
            floorX = 0;
            floorZ += 1;
        }
        // the following code is for the wall left
        for (int i = 0; i < 20; i++){
            for (int j = 0; j < 20; j++){
                Instantiate(blocks, new Vector3(wallX, wallY, wallZ), Quaternion.identity);
                wallZ += 1;
            }
            wallZ = 0;
            wallY += 1;
        }
        // wall right
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Instantiate(blocks, new Vector3(wallRX, wallRY, wallRZ), Quaternion.identity);
                wallRZ += 1;
            }
            wallRZ = 0;
            wallRY += 1;
        }

        // wall BACK
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 19; j++)
            {
                Instantiate(blocks, new Vector3(wallBX, wallBY, wallBZ), Quaternion.identity);
                wallBX += 1;
            }
            wallBX = 1;
            wallBY += 1;
        }


        // wall FRONT
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 19; j++)
            {
                Instantiate(blocks, new Vector3(wallFX, wallFY, wallFZ), Quaternion.identity);
                wallFX += 1;
            }
            wallFX = 1;
            wallFY += 1;
        }

        // roof ?
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Instantiate(blocks, new Vector3(roofX, roofY, roofZ), Quaternion.identity);
                    roofZ += 1;
                }
                roofZ = 0;
                roofX += 1;
                roofY += 1;
        }

        for (int i = 10; i > 0; i--)
        {
            for (int j = 0; j < 20; j++)
            {
                Instantiate(blocks, new Vector3(roofRX, roofRY, roofRZ), Quaternion.identity);
                roofRZ += 1;
            }
            roofRZ = 0;
            roofRX += 1;
            roofRY -= 1;
        }

    } // end start

    // Update is called once per frame
    void Update () {
		
	}
}


/*
 * 
        // stairs
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Instantiate(blocks, new Vector3(roofX, roofY, roofZ), Quaternion.identity);
                    roofZ += 1;
                }
                roofZ = 0;
                roofX += 1;
                roofY += 1;
        }
 * */
