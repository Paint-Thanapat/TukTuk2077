using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class playerControler2 : MonoBehaviour
{
    public AudioClip HitClip;
    public AudioSource HitSource;

    void Start()
    {
        targetMove = new GameObject();
        targetMove.transform.position = new Vector2(0, -5);

        HitSource.clip = HitClip;

    }
    public Sprite[] spriteArr;
    public static float speed = 8;
    int directDX = 0;
    GameObject targetMove;

    void Update()
    {
        if (Vector2.Distance(transform.position, targetMove.transform.position) <= 0.001f)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                OriginalState();
                directDX = 1;
                targetMove.transform.position = new Vector2(targetMove.transform.position.x - 3, targetMove.transform.position.y);
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteArr[1];
                StartCoroutine(TukTuk());
                //print("A " + targetMove.transform.position);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                OriginalState();
                directDX = 1;
                targetMove.transform.position = new Vector2(targetMove.transform.position.x + 3, targetMove.transform.position.y);
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteArr[2];
                StartCoroutine(TukTuk());
                //print("D " + targetMove.transform.position);

            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                OriginalState();
                directDX = 1;
                targetMove.transform.position = new Vector2(targetMove.transform.position.x, targetMove.transform.position.y + 3);
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteArr[0];
                //print("W " + targetMove.transform.position);

            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                OriginalState();
                directDX = 1;
                targetMove.transform.position = new Vector2(targetMove.transform.position.x, targetMove.transform.position.y - 3);
                gameObject.GetComponent<SpriteRenderer>().sprite = spriteArr[0];
                //print("S" + targetMove.transform.position);

            }
        }

        float step = speed * Time.deltaTime * directDX;
        transform.position = Vector2.MoveTowards(transform.position, targetMove.transform.position, step);
        // print("D " + Vector2.Distance(transform.position, targetMove.transform.position));


        // print("Order " + RandomOrder.OrderNum + " Can " + CanCollect);
    }
    public static int isitemfull = 0;
    public static int CanCollect = 0;
    public static int itemInStock = 0;
    public static int PlayerInventory = 1;
    GameObject Original;

    void OriginalState()
    {
        Original = new GameObject();
        Original.transform.position = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.gameObject.tag == "Monster")
        {
            HitSource.Play();
            speed = 2;
            transform.position = Original.transform.position;
            targetMove.transform.position = Original.transform.position;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(SlowPlayer());
        }
        if (hitObject.gameObject.tag == "Blocker")
        {
            HitSource.Play();
            transform.position = Original.transform.position;
            targetMove.transform.position = Original.transform.position;
        }
    }
    private void OnTriggerStay2D(Collider2D hitObject)
    {
        if (hitObject.gameObject.tag == "Balloon")
        {
            CanCollect = 1;
            ItemManagement2.Hitpop = 1;
            print("HitPop = 1");
        }
        if (Input.GetKeyDown(KeyCode.Space) && PlayerInventory == 1 && CanCollect == 1 && ItemManagement2.Hitpop == 1)
        {
            isitemfull = 1;
            itemInStock += 1;
            print("Drone2 full");
        }
    }
    IEnumerator SlowPlayer()
    {
        yield return new WaitForSeconds(1f);
        speed = 8;
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
    IEnumerator TukTuk()
    {
        yield return new WaitForSeconds(0.3f);
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteArr[0];
    }


}
