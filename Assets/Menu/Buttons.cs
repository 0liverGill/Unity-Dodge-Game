using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Buttons : MonoBehaviour
{
    //defines all the buttons
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button endless;
    public Button leaderboard;
    public Button exit;

    void OnEnable()
    {
        //Register Button Events
        level1.onClick.AddListener(() => open1());
        level2.onClick.AddListener(() => open2());
        level3.onClick.AddListener(() => open3());
        level4.onClick.AddListener(() => open4());
        endless.onClick.AddListener(() => openEndless());
        leaderboard.onClick.AddListener(() => openLeaderboard());
        exit.onClick.AddListener(() => openExit());
    }
    //defines what happens when each is clicked

    //loads level 1 scene
    private void open1() { SceneManager.LoadScene(sceneBuildIndex: 1); }

    private void open2() { SceneManager.LoadScene(sceneBuildIndex: 2); }
    //loads level 3
    private void open3() { SceneManager.LoadScene(sceneBuildIndex: 3); }

    private void open4() { SceneManager.LoadScene(sceneBuildIndex: 4); }
    //loads endless mode
    private void openEndless() { SceneManager.LoadScene(sceneBuildIndex: 5); }
    //loads the leaderboard scene
    private void openLeaderboard() { SceneManager.LoadScene(sceneBuildIndex: 6); }
    //will exit the program
    private void openExit()
    {
        Application.Quit();
    }
}
