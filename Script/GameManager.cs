using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prefabsMonCarL1,prefabsMonCarL2;
    public Transform spawnPointL1,spawnPointL2;
    GameObject cloneMonCarL1,cloneMonCarL2;

    public GameObject prefabsMonCarUp1, prefabsMonCarUp2, prefabsMonCarUp3, prefabsMonCarUp4, prefabsMonCarUp5, prefabsMonCarUp6;
    public Transform spawnPointUp1, spawnPointUp2, spawnPointUp3, spawnPointUp4, spawnPointUp5, spawnPointUp6;
    GameObject cloneMonCarUp1, cloneMonCarUp2, cloneMonCarUp3, cloneMonCarUp4, cloneMonCarUp5, cloneMonCarUp6;

    #region Carleft
    public void generateMonCarL1()
    {
        cloneMonCarL1 = Instantiate(prefabsMonCarL1);
        cloneMonCarL1.transform.position = spawnPointL1.position;
        Destroy(cloneMonCarL1, 10.0f);
    }
    public void generateMonCarL2()
    {
        cloneMonCarL2 = Instantiate(prefabsMonCarL2);
        cloneMonCarL2.transform.position = spawnPointL2.position;
        Destroy(cloneMonCarL2, 10.0f);
    }
    #endregion
    #region CarUp
    public void generateMonCarUp1()
    {
        cloneMonCarUp1 = Instantiate(prefabsMonCarUp1);
        cloneMonCarUp1.transform.position = spawnPointUp1.position;
        Destroy(cloneMonCarUp1, 10.0f);
    }
    public void generateMonCarUp2()
    {
        cloneMonCarUp2 = Instantiate(prefabsMonCarUp2);
        cloneMonCarUp2.transform.position = spawnPointUp2.position;
        Destroy(cloneMonCarUp2, 10.0f);
    }
    public void generateMonCarUp3()
    {
        cloneMonCarUp3 = Instantiate(prefabsMonCarUp3);
        cloneMonCarUp3.transform.position = spawnPointUp3.position;
        Destroy(cloneMonCarUp3, 10.0f);
    }
    public void generateMonCarUp4()
    {
        cloneMonCarUp4 = Instantiate(prefabsMonCarUp4);
        cloneMonCarUp4.transform.position = spawnPointUp4.position;
        Destroy(cloneMonCarUp4, 10.0f);
    }
    public void generateMonCarUp5()
    {
        cloneMonCarUp5 = Instantiate(prefabsMonCarUp5);
        cloneMonCarUp5.transform.position = spawnPointUp5.position;
        Destroy(cloneMonCarUp5, 10.0f);
    }
    public void generateMonCarUp6()
    {
        cloneMonCarUp6 = Instantiate(prefabsMonCarUp6);
        cloneMonCarUp6.transform.position = spawnPointUp6.position;
        Destroy(cloneMonCarUp6, 10.0f);
    }
    #endregion

    #region IEleft
    IEnumerator ForCarL1()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarL1();
            
        }

    }
    IEnumerator ForCarL2()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarL2();
            
        }

    }
    #endregion
    #region IEUp
    IEnumerator ForCarUp1()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarUp1();
        }

    }
    IEnumerator ForCarUp2()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarUp2();
        }

    }
    IEnumerator ForCarUp3()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarUp3();
        }

    }
    IEnumerator ForCarUp4()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarUp4();
        }

    }
    IEnumerator ForCarUp5()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarUp5();
        }

    }
    IEnumerator ForCarUp6()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5, 10));
            generateMonCarUp6();
        }

    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ForCarL1());
        StartCoroutine(ForCarL2());
        StartCoroutine(ForCarUp1());
        StartCoroutine(ForCarUp2());
        StartCoroutine(ForCarUp3());
        StartCoroutine(ForCarUp4());
        StartCoroutine(ForCarUp5());
        StartCoroutine(ForCarUp6());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
