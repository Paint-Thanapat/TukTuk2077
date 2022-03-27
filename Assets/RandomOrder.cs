using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOrder : MonoBehaviour
{
    public GameObject prefabPopup;
    public Transform popPosition;
    GameObject clonePopup;

    public void genPopup()
    {
        clonePopup = Instantiate(prefabPopup);
        clonePopup.transform.position = popPosition.position;
        Destroy(clonePopup, 5f);

    }

   // public GameObject OrderPic;
    // Start is called before the first frame update
    void Start()
    {
       // OrderPic.SetActive(false);
        StartCoroutine(RandomShowPic());
    }

    IEnumerator RandomShowPic()
    {
        while (true)
        {
            int secRand = Random.Range(6, 10);
            yield return new WaitForSeconds(secRand);
            genPopup();

        }

    }
    public static int OrderNum = 0;
    /*
    void RandomPicture()
    {
        //OrderNum = Random.Range(1, 4);

        if (OrderNum == 1)
        {
            OrderPic.SetActive(true);
            print("PictureVisible");
        }
        else
        {
            OrderPic.SetActive(false);
            print("PictureInvisible");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    */
}
