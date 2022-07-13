using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class Product : MonoBehaviour
{
   
    public GameObject shop;
    public int id;
    public string productName;
    public int price;
    public Text nameText, priceText;
   
   
    // Start is called before the first frame update
    void Start()
    {
        shop = GameObject.Find("Shop");
        //productName = shop.GetComponent<Shop>().productName[id];
        //price = shop.GetComponent<Shop>().price[id];
    }

    // Update is called once per frame
    void Update()
    {
        nameText.text = "" + productName;
        priceText.text = price + " $";

        productName = shop.GetComponent<Shop>().productName[id];
        price = shop.GetComponent<Shop>().price[id];
    }
}
