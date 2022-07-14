using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{


    public int[] id;
    public string[] productName;
    public int[] price;

    public int numberOfProducts;
    public GameObject shopWindow;

    public GameObject[] products;


    public int pageNumber;
    public static bool beInShop;




    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            products[i].SetActive(false);
        }

        Refresh();

    }

    // Update is called once per frame
    void Update()
    {
        if (Product.isSowing)
        {
            CloseShop();
        }
    }

    public void OpenShop()
    {
        shopWindow.SetActive(true);
        beInShop = true;
        Refresh();

    }

    public void CloseShop()
    {
        shopWindow.SetActive(false);
        beInShop = false;
    }

    public void Refresh()
    {
        for (int i = 0; i < numberOfProducts; i++)
        {
            products[i].SetActive(false);
        }

        if (pageNumber == 1)
        {
            for (int i = 0; i < numberOfProducts; i++)
            {
                products[i].GetComponent<Product>().id = id[i];
                products[i].SetActive(true);
            }
        }
    }

    public void Left()
    {

    }

    public void Right()
    {

    }
}
