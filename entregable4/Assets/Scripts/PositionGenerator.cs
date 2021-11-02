using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    private int posX;
    private int posY;
    private int posZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RandomPosition (transform.position = Vector3.right);
            RandomPosition(transform.position = Vector3.up);
            RandomPosition(transform.position = Vector3.forward);
            RandomPosition(transform.position = Vector3.left);
            RandomPosition(transform.position = Vector3.down);
            RandomPosition(transform.position = Vector3.back);


        }
    }

    public void RandomPosition (Vector3 position)
    {
        posX = Random.Range(0, 8);
        posY = Random.Range(0, 8);
        posZ = Random.Range(0, 8);
        transform.position = new Vector3(posX, posY, posZ);
    }
}
