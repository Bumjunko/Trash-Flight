using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private GameObject gameOverPanel;

    private int coin = 0;

    [HideInInspector]
    public bool isGameOver = false;

    [HideInInspector]
    public bool isGameClear = false;

    void Awake() {
        instance = this;
        isGameOver = false;
        isGameClear = false;

        if (gameOverPanel == null) {
            GameObject panelObject = GameObject.Find("GameOverPanel");
            if (panelObject != null) {
                gameOverPanel = panelObject;
            }
        }

        if (gameOverPanel != null) {
            gameOverPanel.SetActive(false);
        }
    }

    public void IncreaseCoin() {
        coin += 1;
        text.SetText(coin.ToString());

        // 30
        if (coin % 30 == 0) { //30, 60, 90, ...
            Player player = FindFirstObjectByType<Player>();
            if (player != null) {
                player.Upgrade();
            }
        }
    }

    public void SetGameOver() {
        isGameOver = true;

        EnemySpawner spawner = FindFirstObjectByType<EnemySpawner>();
        if (spawner != null) {
            spawner.stopEnemyRoutine();
        }
        Invoke("showGameOverPanel", 1f);
    }

    public void SetGameClear() {
        isGameClear = true;

        EnemySpawner spawner = FindFirstObjectByType<EnemySpawner>();
        if (spawner != null) {
            spawner.stopEnemyRoutineForClear();
        }
        Invoke("showGameOverPanel", 1f);
    }

    void showGameOverPanel() {
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain() {
        SceneManager.LoadScene("SampleScene");
    }
}
