using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{


    public int[] id;
    public string[] productName;
    public int [] price;
    
    public int numberOfProducts;
    public GameObject shopWindow;
    public GameObject productPrefab;

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenShop()
    {
        shopWindow.SetActive(true);
    }

    public void CloseShop()
    {
        shopWindow.SetActive(false);
    }
}
