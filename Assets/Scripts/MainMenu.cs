using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Text leaderboard;

    void Start()
    {
        Debug.Log(SaveData.path);
        string s = SaveData.GetSaveData();
        if (s != "")
            leaderboard.text = s;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("WaterMaze", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
