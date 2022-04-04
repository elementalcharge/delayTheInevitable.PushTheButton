using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winSystem : MonoBehaviour
{
    [SerializeField] List<GameObject> listOfItemsToWin;
    [SerializeField] bool didIWin = false;
    [SerializeField] GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(listOfItemsToWin.Capacity == 0)
        {
            didIWin = true;
            winScreen.SetActive ( didIWin);
        }
        
    }

    internal void removeMeFromList(GameObject gameObject)
    {
        listOfItemsToWin.Remove(gameObject);
    }
}
