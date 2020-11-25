using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachAssets : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public int gridX;
    public int gridZ;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrigin = Vector3.zero;
    int x;
    int z;


    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
        
    }

    void SpawnGrid()
    {
        //création de la grille avec valeur en x(longueur) et z(largeur)
        for (x = 0; x < gridX; x++)
        {
            print("x: " + x);
            for (z = 0; z < gridZ; z++)
            {
                print("z: " + z);
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrigin;
                PickAndSpawn(spawnPosition, Quaternion.identity);
                
            }
            
        }
    }

    void PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {

        //pick d'une salle aléatoire entre les 5 salles
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        bool loop = false;

        //GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
        //clone.transform.localScale = new Vector3(100f, 100f, 100f);        

        while (loop == false)
        {
            if (allSeg(0, 0, 0, itemsToPickFrom[randomIndex].GetComponent<packLaby>().top) && x == 0 && z == 0)
            {
                loop = true;
                GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
            }
            if (allSeg(0, 1, 0, itemsToPickFrom[randomIndex].GetComponent<packLaby>().top) && x == 0 && z == 1)
            {
                loop = true;
                GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
            }
            if (allSeg(0, 0, 0, itemsToPickFrom[randomIndex].GetComponent<packLaby>().top) && x == 0 && z == 2)
            {
                loop = true;
                GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
            }
            if (allSeg(0, 0, 0, itemsToPickFrom[randomIndex].GetComponent<packLaby>().top) && x == 1 && z == 0)
            {
                loop = true;
                GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
            }
            if (allSeg(0, 1, 0, itemsToPickFrom[randomIndex].GetComponent<packLaby>().top) && x == 1 && z == 1)
            {
                loop = true;
                GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
            }
            if (allSeg(0, 0, 0, itemsToPickFrom[randomIndex].GetComponent<packLaby>().top) && x == 1 && z == 2)
            {
                loop = true;
                GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
            }
        }

        /*toto[0] = 0;
        toto[1] = 1;
        toto[2] = 0;
        if (itemsToPickFrom[randomIndex].GetComponent<packLaby>().top == toto && x == 0 && z == 1)
        {
            GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
        }
        toto[0] = 0;
        toto[1] = 0;
        toto[2] = 0;
        if (itemsToPickFrom[randomIndex].GetComponent<packLaby>().top == toto && itemsToPickFrom[randomIndex].GetComponent<packLaby>().right == toto && x == 0 && z == 2)
        {
            GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
        }
        toto[0] = 0;
        toto[1] = 0;
        toto[2] = 0;
        if (itemsToPickFrom[randomIndex].GetComponent<packLaby>().left == toto && itemsToPickFrom[randomIndex].GetComponent<packLaby>().bot == toto && x == 1 && z == 0)
        {
            GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
        }
        toto[0] = 0;
        toto[1] = 1;
        toto[2] = 0;
        if (itemsToPickFrom[randomIndex].GetComponent<packLaby>().bot == toto && x == 1 && z == 1)
        {
            GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
        }
        toto[0] = 0;
        toto[1] = 0;
        toto[2] = 0;
        if (itemsToPickFrom[randomIndex].GetComponent<packLaby>().right == toto && itemsToPickFrom[randomIndex].GetComponent<packLaby>().bot == toto && x == 1 && z == 2)
        {
            GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90, 0), itemsToPickFrom[randomIndex].transform.parent);
        }*/
    }
    bool top(int a,int b,int c, int random)
    {
        if (itemsToPickFrom[random].GetComponent<packLaby>().top[0] == 0 && itemsToPickFrom[random].GetComponent<packLaby>().top[1] == b && itemsToPickFrom[random].GetComponent<packLaby>().top[2] == c)
            return (true);
        return (false);
    }
    bool right(int a, int b, int c, int random)
    {
        if (itemsToPickFrom[random].GetComponent<packLaby>().right[0] == 0 && itemsToPickFrom[random].GetComponent<packLaby>().right[1] == b && itemsToPickFrom[random].GetComponent<packLaby>().right[2] == c)
            return (true);
        return (false);
    }
    bool bot(int a, int b, int c, int random)
    {
        if (itemsToPickFrom[random].GetComponent<packLaby>().bot[0] == 0 && itemsToPickFrom[random].GetComponent<packLaby>().bot[1] == b && itemsToPickFrom[random].GetComponent<packLaby>().bot[2] == c)
            return (true);
        return (false);
    }
    bool left(int a, int b, int c, int random)
    {
        if (itemsToPickFrom[random].GetComponent<packLaby>().left[0] == 0 && itemsToPickFrom[random].GetComponent<packLaby>().left[1] == b && itemsToPickFrom[random].GetComponent<packLaby>().left[2] == c)
            return (true);
        return (false);
    }
    bool allSeg(int a, int b, int c, int [] tab)
    {
        if (tab[0] == a && tab[1] == b && tab[2] == c)
        {
            return (true);
        }
        return (false);
    }
}
