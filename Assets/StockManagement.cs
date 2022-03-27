using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StockManagement : MonoBehaviour
{
    public Sprite[] SlotImage;
    public Image[] Slot1;
    public Image[] ImageHolder1;
    public Image[] Slot2;
    public Image[] ImageHolder2;
    bool stock1Empty1 = true;
    bool stock2Empty1 = true;
    bool stock3Empty1 = true;
    bool stock1Empty2 = true;
    bool stock2Empty2 = true;
    bool stock3Empty2 = true;
    public GameObject Bonus;
    public GameObject Bonus2;

    public AudioClip PickClip;
    public AudioSource PickSource;

    void Start()
    {
        ImageHolder1[0].gameObject.SetActive(false);
        ImageHolder2[0].gameObject.SetActive(false);

        PickSource.clip = PickClip;
    }

    void Update()
    {
        if (ItemManagement.idForHolder >= 1)
        {
            ImageHolder1[0].gameObject.SetActive(true);
        }
        else
        {
            ImageHolder1[0].gameObject.SetActive(false);
        }
            ImageHolder1[0].sprite = SlotImage[ItemManagement.idForSlot];

        ////////////////////////////////////////////////////////////////////
        if (ItemManagement2.idForHolder >= 1)
        {
            ImageHolder2[0].gameObject.SetActive(true);
        }
        else
        {
            ImageHolder2[0].gameObject.SetActive(false);
        }
            ImageHolder2[0].sprite = SlotImage[ItemManagement2.idForSlot];

        if (playerControler.isitemfull == 0)
        {
            print("Drone1 Empty");
        }
    }

    int pop1p1, pop2p1, pop3p1, pop4p1, pop5p1, pop6p1;
    int pop1p2, pop2p2, pop3p2, pop4p2, pop5p2, pop6p2;

    private void OnTriggerStay2D(Collider2D hitObjects)
    {
        if(hitObjects.gameObject.name == "Player" && Input.GetKeyDown(KeyCode.RightShift))
        {
            print("Player1 Send Pop");

            if (ItemManagement.idForHolder == 1)
            {
                pop1p1 += 1;
            }
            if (ItemManagement.idForHolder == 2)
            {
                pop2p1 += 1;
            }
            if (ItemManagement.idForHolder == 3)
            {
                pop3p1 += 1;
            }
            if (ItemManagement.idForHolder == 4)
            {
                pop4p1 += 1;
            }
            if (ItemManagement.idForHolder == 5)
            {
                pop5p1 += 1;
            }
            if (ItemManagement.idForHolder == 6)
            {
                pop6p1 += 1;
            }

            if (playerControler.itemInStock == 1 && stock1Empty1 && ItemManagement.idForHolder >= 1)
            {
                PickSource.Play();
                print("You Have " + ItemManagement.idForHolder + "In Stock 1");
                Slot1[0].gameObject.SetActive(true);
                Slot1[0].sprite = SlotImage[ItemManagement.idForSlot];
                stock1Empty1 = false;
                playerControler.isitemfull = 0;
                playerControler.CanCollect = 0;
                playerControler.PlayerInventory = 1;
                ItemManagement.idForHolder = 0;
                ItemManagement.Hitpop = 0;

            }
            if (playerControler.itemInStock == 2 && stock2Empty1 && ItemManagement.idForHolder >= 1)
            {
                PickSource.Play();
                print("You Have " + ItemManagement.idForHolder + "In Stock 2");
                Slot1[1].gameObject.SetActive(true);
                Slot1[1].sprite = SlotImage[ItemManagement.idForSlot];
                stock2Empty1 = false;
                playerControler.isitemfull = 0;
                playerControler.CanCollect = 0;
                playerControler.PlayerInventory = 1;
                ItemManagement.idForHolder = 0;
                ItemManagement.Hitpop = 0;
            }
            if (playerControler.itemInStock == 3 && stock3Empty1 && ItemManagement.idForHolder >= 1)
            {
                playerControler.speed = 0;
                PickSource.Play();
                print("You Have " + ItemManagement.idForHolder + "In Stock 3");
                Slot1[2].gameObject.SetActive(true);
                Slot1[2].sprite = SlotImage[ItemManagement.idForSlot];
                stock3Empty1 = false;
                StartCoroutine(sumScoreX());
                playerControler.isitemfull = 0;
                playerControler.CanCollect = 0;
                playerControler.PlayerInventory = 1;
                ItemManagement.idForHolder = 0;
                ItemManagement.Hitpop = 0;
                StopCoroutine(sumScoreX());
                playerControler.speed = 8;

                ScoreManager.ScoreValue += pop1p1 * 20;
                ScoreManager.ScoreValue += pop2p1 * 20;
                ScoreManager.ScoreValue += pop3p1 * 20;
                ScoreManager.ScoreValue += pop4p1 * 30;
                ScoreManager.ScoreValue += pop5p1 * 30;
                ScoreManager.ScoreValue += pop6p1 * 50;

                if (pop1p1 == 3)
                {
                    ScoreManager.ScoreValue += 20;
                    Bonus.SetActive(true);
                    StartCoroutine(CloseBonus());
                }
                if (pop2p1 == 3)
                {
                    ScoreManager.ScoreValue += 20;
                    Bonus.SetActive(true);
                    StartCoroutine(CloseBonus());
                }
                if (pop3p1 == 3)
                {
                    ScoreManager.ScoreValue += 20;
                    Bonus.SetActive(true);
                    StartCoroutine(CloseBonus());
                }
                if (pop4p1 == 3)
                {
                    ScoreManager.ScoreValue += 60;
                    Bonus.SetActive(true);
                    StartCoroutine(CloseBonus());
                }
                if (pop5p1 == 3)
                {
                    ScoreManager.ScoreValue += 60;
                    Bonus.SetActive(true);
                    StartCoroutine(CloseBonus());
                }
                if (pop6p1 == 3)
                {
                    ScoreManager.ScoreValue += 50;
                    Bonus.SetActive(true);
                    StartCoroutine(CloseBonus());
                }

                pop1p1 = 0;
                pop2p1 = 0;
                pop3p1 = 0;
                pop4p1 = 0;
                pop5p1 = 0;
                pop6p1 = 0;

            }
        }
                ////////////////////////////////////////////////////////////////////////////////////////

        if (hitObjects.gameObject.name == "Player2" && Input.GetKeyDown(KeyCode.Space))
        {
            print("Player2 Send Pop");

            if (ItemManagement2.idForHolder == 1)
            {
                pop1p2 += 1;
            }
            if (ItemManagement2.idForHolder == 2)
            {
                pop2p2 += 1;
            }
            if (ItemManagement2.idForHolder == 3)
            {
                pop3p2 += 1;
            }
            if (ItemManagement2.idForHolder == 4)
            {
                pop4p2 += 1;
            }
            if (ItemManagement2.idForHolder == 5)
            {
                pop5p2 += 1;
            }
            if (ItemManagement2.idForHolder == 6)
            {
                pop6p2 += 1;
            }

            if (playerControler2.itemInStock == 1 && stock1Empty2 && ItemManagement2.idForHolder >= 1)
            {
                PickSource.Play();
                print("You Have " + ItemManagement2.idForHolder + "In Stock 1");
                Slot2[0].gameObject.SetActive(true);
                Slot2[0].sprite = SlotImage[ItemManagement2.idForSlot];
                stock1Empty2 = false;
                playerControler2.isitemfull = 0;
                playerControler2.CanCollect = 0;
                playerControler2.PlayerInventory = 1;
                ItemManagement2.idForHolder = 0;
                ItemManagement2.Hitpop = 0;

            }
            if (playerControler2.itemInStock == 2 && stock2Empty2 && ItemManagement2.idForHolder >= 1)
            {
                PickSource.Play();
                print("You Have " + ItemManagement2.idForHolder + "In Stock 2");
                Slot2[1].gameObject.SetActive(true);
                Slot2[1].sprite = SlotImage[ItemManagement2.idForSlot];
                stock2Empty2 = false;
                playerControler2.isitemfull = 0;
                playerControler2.CanCollect = 0;
                playerControler2.PlayerInventory = 1;
                ItemManagement2.idForHolder = 0;
                ItemManagement2.Hitpop = 0;
            }
            if (playerControler2.itemInStock == 3 && stock3Empty2 && ItemManagement2.idForHolder >= 1)
            {
                PickSource.Play();
                print("You Have " + ItemManagement2.idForHolder + "In Stock 3");
                Slot2[2].gameObject.SetActive(true);
                Slot2[2].sprite = SlotImage[ItemManagement2.idForSlot];
                stock3Empty2 = false;
                StartCoroutine(sumScoreX2());
                playerControler2.isitemfull = 0;
                playerControler2.CanCollect = 0;
                playerControler2.PlayerInventory = 1;
                ItemManagement2.idForHolder = 0;
                ItemManagement2.Hitpop = 0;
                StopCoroutine(sumScoreX2());

                ScoreManager2.ScoreValue += pop1p2 * 20;
                ScoreManager2.ScoreValue += pop2p2 * 20;
                ScoreManager2.ScoreValue += pop3p2 * 20;
                ScoreManager2.ScoreValue += pop4p2 * 30;
                ScoreManager2.ScoreValue += pop5p2 * 30;
                ScoreManager2.ScoreValue += pop6p2 * 50;

                if (pop1p2 == 3)
                {
                    ScoreManager2.ScoreValue += 20;
                    Bonus2.SetActive(true);
                    StartCoroutine(CloseBonus2());
                }
                if (pop2p2 == 3)
                {
                    ScoreManager2.ScoreValue += 20;
                    Bonus2.SetActive(true);
                    StartCoroutine(CloseBonus2());
                }
                if (pop3p2 == 3)
                {
                    ScoreManager2.ScoreValue += 20;
                    Bonus2.SetActive(true);
                    StartCoroutine(CloseBonus2());
                }
                if (pop4p2 == 3)
                {
                    ScoreManager2.ScoreValue += 60;
                    Bonus2.SetActive(true);
                    StartCoroutine(CloseBonus2());
                }
                if (pop5p2 == 3)
                {
                    ScoreManager2.ScoreValue += 60;
                    Bonus2.SetActive(true);
                    StartCoroutine(CloseBonus2());
                }
                if (pop6p2 == 3)
                {
                    ScoreManager2.ScoreValue += 50;
                    Bonus2.SetActive(true);
                    StartCoroutine(CloseBonus2());
                }

                pop1p2 = 0;
                pop2p2 = 0;
                pop3p2 = 0;
                pop4p2 = 0;
                pop5p2 = 0;
                pop6p2 = 0;

            }
        }
    }

    ///////////////////////////////////////////
   
    IEnumerator sumScoreX()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 3; i++)
        Slot1[i].gameObject.SetActive(false);
        playerControler.itemInStock = 0;
        stock1Empty1 = stock2Empty1 = stock3Empty1 = true;
    }

    ///////////////////////////////////////////

    IEnumerator sumScoreX2()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 3; i++)
        Slot2[i].gameObject.SetActive(false);
        playerControler2.itemInStock = 0;
        stock1Empty2 = stock2Empty2 = stock3Empty2 = true;
    }

    ///////////////////////////////////////////
    IEnumerator CloseBonus()
    {
        yield return new WaitForSeconds(1.5f);
        Bonus.SetActive(false);
    }

    ///////////////////////////////////////////

    IEnumerator CloseBonus2()
    {
        yield return new WaitForSeconds(1.5f);
        Bonus2.SetActive(false);
    }
    void sumScore()
    {
        for (int i = 0; i < 3; i++)
            Slot1[i].gameObject.SetActive(false);
        playerControler.itemInStock = 0;
        stock1Empty1 = stock2Empty1 = stock3Empty1 = true;
    }
    void sumScore2()
    {
        for (int i = 0; i < 3; i++)
            Slot2[i].gameObject.SetActive(false);
        playerControler2.itemInStock = 0;
        stock1Empty2 = stock2Empty2 = stock3Empty2 = true;
    }
}
