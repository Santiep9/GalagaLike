using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject orcoPrefab;
    public int maxOrcos = 5;               // Máximos enemigos en simultáneo
    public float spawnRate = 1.5f;         // Segundos entre spawn
    public float xMin = -3.5f, xMax = 3.5f; // Límites X
    public float spawnY = 5f;              // Altura de aparición
    public TextMeshProUGUI marcador;
    public TextMeshProUGUI textoGameOver;  //  UI 

    private int puntos = 0;
    private int orcosEnEscena = 0;

    void Start()
    {
        InvokeRepeating("SpawnOrco", 1f, spawnRate);
        if (marcador != null)
            marcador.text = "Puntos: 0";
        if (textoGameOver != null)
            textoGameOver.gameObject.SetActive(false);
        Time.timeScale = 1f; // Juego no pausado al iniciar/reiniciar
    }

    void SpawnOrco()
    {
        if (orcosEnEscena >= maxOrcos) return;
        Vector3 pos = new Vector3(Random.Range(xMin, xMax), spawnY, 0f);
        Instantiate(orcoPrefab, pos, Quaternion.identity);
        orcosEnEscena++;
    }

    public void SumarPunto()
    {
        puntos++;
        if (marcador != null)
            marcador.text = "Puntos: " + puntos;
    }

    public void OrcoMuerto()
    {
        orcosEnEscena = Mathf.Max(orcosEnEscena - 1, 0);
    }

    public void GameOver()
    {
        if (textoGameOver != null)
            textoGameOver.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}