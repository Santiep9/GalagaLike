using NUnit.Framework.Constraints;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject orcPrefab;
    public int maxEnemy = 2;

    void Start()
    {
        for (int i=0; i < maxEnemy; i++)
        {
            GameObject enemy =Instantiate(orcPrefab);
            enemy.name = "Enemy_" + i;
        }
    }
}
