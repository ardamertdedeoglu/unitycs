using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnBasketManager : MonoBehaviour
{
    public GameObject basketPrefab;
    private GameObject[] baskets;

    private void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Basket").Length < 1)
        {
            SpawnBasket();
        }
    }
    public void SpawnBasket()
    {
        Instantiate(basketPrefab, new Vector3(Random.Range(-9, 9), 0, Random.Range(-9, 9)), Quaternion.identity);
    }
}
