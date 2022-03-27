using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManagement2 : MonoBehaviour
{
    public Sprite[] spriteArr;
    public static int ItemID;
    public static int idForSlot;
    public static int idForHolder;
    public static int Hitpop = 0;

    void Start()
    {
        ItemID = Random.Range(0, 6);
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteArr[ItemID];

    }

    void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D hitObject)
    {

        if (hitObject.gameObject.name == "Player2")
        {
            if (playerControler2.isitemfull == 1 && playerControler2.PlayerInventory == 1 && Hitpop == 1 && playerControler2.CanCollect == 1)
            {
                if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "Pop1")
                {
                    print("Pick name " + gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    idForSlot = 0;
                    idForHolder = 1;
                    playerControler2.PlayerInventory = 0;
                    print("Inventory = 0");
                    Destroy(gameObject);
                }
                else if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "Pop2")
                {
                    print("Pick name " + gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    idForSlot = 1;
                    idForHolder = 2;
                    playerControler2.PlayerInventory = 0;
                    print("Inventory = 0");
                    Destroy(gameObject);
                }
                else if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "Pop3")
                {
                    print("Pick name " + gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    idForSlot = 2;
                    idForHolder = 3;
                    playerControler2.PlayerInventory = 0;
                    print("Inventory = 0");
                    Destroy(gameObject);
                }
                else if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "Pop4")
                {
                    print("Pick name " + gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    idForSlot = 3;
                    idForHolder = 4;
                    playerControler2.PlayerInventory = 0;
                    print("Inventory = 0");
                    Destroy(gameObject);
                }
                else if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "Pop5")
                {
                    print("Pick name " + gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    idForSlot = 4;
                    idForHolder = 5;
                    playerControler2.PlayerInventory = 0;
                    print("Inventory = 0");
                    Destroy(gameObject);
                }
                else if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "Pop6")
                {
                    print("Pick name " + gameObject.GetComponent<SpriteRenderer>().sprite.name);
                    idForSlot = 5;
                    idForHolder = 6;
                    playerControler2.PlayerInventory = 0;
                    print("Inventory = 0");
                    Destroy(gameObject);
                }
            }
        }
    }
}
