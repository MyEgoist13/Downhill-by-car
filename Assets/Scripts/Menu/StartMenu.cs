using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    public GameRules gr;
    public GameObject LevelsPanel, CarChooser, redModelCar;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void ChooseLevel(int lvlNum)
    {
        gr.levelNumber = lvlNum;
        LevelsPanel.SetActive(false);
        CarChooser.SetActive(true);
        redModelCar.SetActive(true);
    }

    public void StartGame()
    {
        gr.LoadGameScene();
    }
}
