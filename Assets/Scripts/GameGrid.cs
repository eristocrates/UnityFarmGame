using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
    //declarations for game baord creation
    public int columnLength, rowLength;
    public float x_Space, z_Space;
    public GameObject grass;
    public GameObject[] currentGrid;
    public bool gotGrid;
    
   //declarations for field creation
   public GameObject hitted;
   public GameObject field;
   private RaycastHit _Hit;
   public bool creatingFields;

   
    //declarations for cursors
   public Texture2D basicCursor, fieldCursor;
   public CursorMode cursorMode = CursorMode.Auto;
   public Vector3 hotSpot = Vector3.zero;

    //declartion for money system
   public GameObject goldSystem;
   public int fieldsPrice;


   //defaut cursor when game turns on
   void Awake()
   {
        Cursor.SetCursor(basicCursor, hotSpot, cursorMode);
   }
  
   
   
    void Start()
    {
        for(int i = 0; i < columnLength * rowLength; i++){
            Instantiate(grass, new Vector3(x_Space + (x_Space * ( i % columnLength)), 0, z_Space + (z_Space * (i / columnLength))), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!gotGrid){
            currentGrid = GameObject.FindGameObjectsWithTag("grid");
            gotGrid = true;
        }

        
    // Button for creating feilds
        if(Input.GetMouseButtonDown (0))
        {
            if(Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition), out _Hit))
            {
                if(creatingFields == true)
                {
                    if(_Hit.transform.tag == "grid" && goldSystem.GetComponent<GoldSystem>().gold >= fieldsPrice) //creats field and checks to see if player has money
                    {
                        hitted = _Hit.transform.gameObject;
                        Instantiate(field,hitted.transform.position, Quaternion.identity);
                        Destroy(hitted);

                        goldSystem.GetComponent<GoldSystem>().gold -= fieldsPrice; //once field is purchase money goes lower
                    }
                }
            }
            
        }
        
        //when creating field mouse press cursor will change to appropiate cursor
        if(creatingFields == true)
            {
                Cursor.SetCursor(fieldCursor, hotSpot, cursorMode); 
            }
        

    }

    

    public void CreateFields()
    {
        creatingFields = true;
    }

    public void returnToNormality()
    {
        creatingFields = false;
    }

    
}
