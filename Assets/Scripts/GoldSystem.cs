using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GoldSystem : MonoBehaviour
{
   
   
   public int gold;

   public Text goldText;
   
   
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = gold + " $";
    }
}
