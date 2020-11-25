using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laby : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    public int gridX;
    public int gridZ;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrigin = Vector3.zero;
    public List<GameObject> labyr = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
    }

    void SpawnGrid()
    {
        //création de la grille avec valeur en x(longueur) et z(largeur)
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridZ; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrigin;
                PickAndSpawn(spawnPosition, Quaternion.identity);
            }
        }
    }

    void PickAndSpawn(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
        //pick d'une salle aléatoire entre les 5 salles
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        int randomSalle123 = Random.Range(0, 2);
        int randomAngle = Random.Range(0, 3);
        
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], positionToSpawn, rotationToSpawn * Quaternion.Euler(0, 90 * randomAngle, 0), itemsToPickFrom[randomIndex].transform.parent);
        clone.transform.localScale = new Vector3(100f, 100f, 100f);
        labyr.Add(clone);
    }

    void backtrack()
    {
        //elem0 = start (en haut à gauche)
        //elemLast = end (en bas à droite)
    

    }


    // void OnDrawGizmos()
    // {
    //     Color color;
    //     color = Color.blue;
    // local forward
    //     DrawHelperAtCenter(this.transform.forward, color, 2f);
    // }
    // private void DrawHelperAtCenter(Vector3 direction, Color color, float scale)
    // {
    //     Gizmos.color = color;
    //     Vector3 destination = transform.position + direction * scale;
    //     Gizmos.DrawLine(transform.position, destination);
    // }
}

