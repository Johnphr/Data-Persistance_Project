using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;
using UnityEditor;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScore;

    // Start is called before the first frame update
    void Start()
    {
        bestScore.text = "Best Score: " + SaveManager.bestPlayer + ": " + SaveManager.bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeName(string input)
    {
        SaveManager.playerName = input;
    }
    public void Exit()
    {
        Debug.Log(SaveManager.bestScore);
        Debug.Log(SaveManager.bestPlayer);
        SaveManager.Instance.Save();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
