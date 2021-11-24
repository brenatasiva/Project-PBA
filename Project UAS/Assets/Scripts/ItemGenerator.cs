using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemGenerator : MonoBehaviour
{
    public GameObject item;
    private GameObject ground;
    public GameObject ground1;
    public GameObject ground2;
    public GameObject ground3;
    public GameObject ground4;
    public TMP_Text itemCountText;
    int itemCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 3; i++)
        {
            if (i == 0) ground = ground1;
            if (i == 1) ground = ground2;
            if (i == 2) ground = ground3;
            if (i == 3) ground = ground4;
            float moveAreaX = ground.GetComponent<Renderer>().bounds.size.x / 2;
            float moveAreaZ = ground.GetComponent<Renderer>().bounds.size.z / 2;
            float Y = ground.transform.position.y;
            float thirdZ = ground.GetComponent<Renderer>().bounds.size.z / 3;
            Vector3 center = ground.GetComponent<Renderer>().bounds.center;

            for (int j = 0; j < 3; j++)
            {
                Instantiate(item, new Vector3(center.x + Random.Range(-moveAreaX, moveAreaX), Y + 1.1f, center.z + Random.Range(-moveAreaZ + j * thirdZ, -moveAreaZ + (j + 1) * thirdZ)), Quaternion.identity);
                itemCount++;
            }
        }
        itemCountText.text = itemCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
