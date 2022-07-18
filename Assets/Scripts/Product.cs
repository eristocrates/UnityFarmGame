using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class Product : MonoBehaviour
{

    public GameObject shop;
    public GameObject goldSystem;
    public int id;
    public string productName;
    public int price;
    public Text nameText, priceText;
    public static bool placeSeeds;
    public static int whichSeed;
    public static bool isSowing;

    //new

    public static int currentProductPrice;

    //new end


    // Start is called before the first frame update
    void Start()
    {
        shop = GameObject.Find("Shop");
        goldSystem = GameObject.Find("Gold System");
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
    public void Buy()
    {
        if (goldSystem.GetComponent<GoldSystem>().gold >= price)
        {
            placeSeeds = true;
            whichSeed = id;
            goldSystem.GetComponent<GoldSystem>().gold -= price;

            //new

            currentProductPrice = price;


            //new end



            isSowing = true;
        }
    }
}
