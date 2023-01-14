using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public GameObject card;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;

    private void Start()
    {
        SpawnCard();
    }
    private void SpawnCard()
    { //401 
        GameObject newCard = GameObject.Instantiate(card, new Vector3(200,336,0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        GameObject newCard2 = GameObject.Instantiate(card2, new Vector3(600, 336, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        GameObject newCard3 = GameObject.Instantiate(card3, new Vector3(1000, 336, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        GameObject newCard4 = GameObject.Instantiate(card4, new Vector3(1400, 336, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        GameObject newCard5 = GameObject.Instantiate(card5, new Vector3(1750, 336, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

    }
}
