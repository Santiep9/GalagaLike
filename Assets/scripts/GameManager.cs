using NUnit.Framework.Constraints;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public GameObject orcPrefab;
    public int maxOrc = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i=0; i < maxOrc; i++)
        {
            GameObject orc =Instantiate(orcPrefab);
            orc.name = "Orco_" + i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
