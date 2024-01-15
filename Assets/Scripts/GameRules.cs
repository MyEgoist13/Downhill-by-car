using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameRules : MonoBehaviour
{
    public int levelNumber = 2;
    public GameObject WinPanel, RestartPanel;//, Loader;
    private bool gameWork = true;
    public RootMotion.CameraController CameraCtrl;

    public CarColorChooser CarClrC;

    public Transform Platforms, Barriers, Triggers;
    //Prefabs:
    public GameObject Platform1, Platform2, Platform3, Barrier1, Barrier2, WinTrigger;

    private void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    public void LoadGameScene(int lvlNum)
    {
        levelNumber = lvlNum;
        PlayerPrefs.SetInt("levelNumber", levelNumber);
        SceneManager.LoadScene("Game");
    }

    public void LoadGameScene()
    {
        PlayerPrefs.SetInt("levelNumber", levelNumber);
        SceneManager.LoadScene("Game");
    }

    public void BuildLevel()
    {
        levelNumber = PlayerPrefs.GetInt("levelNumber");
        if(levelNumber == 1)
        {
            /*var plat1 = Instantiate(Platform1, new Vector3(-200, 80, 0), Quaternion.identity);
            var plat2 = Instantiate(Platform2, new Vector3(-200, 70, 65), Quaternion.identity);
            var plat3 = Instantiate(Platform3, new Vector3(-200, 60, 150), Quaternion.identity);
            var plat4 = Instantiate(Platform3, new Vector3(-200, 30, 270), Quaternion.identity);
            var barr1 = Instantiate(Barrier1, new Vector3(-200, 105, 63), Quaternion.identity);
            var trg1 = Instantiate(WinTrigger, new Vector3(-200, 18, 330), Quaternion.Euler(10, Quaternion.identity.y, Quaternion.identity.z));
            //var barr2 = Instantiate(Barrier2, new Vector3(-200, 86.2f, 95), Quaternion.identity);*/
            CarClrC.colorCode = PlayerPrefs.GetInt("colorCode");

            /*plat1.transform.parent = Platforms;
            plat2.transform.parent = Platforms;
            plat3.transform.parent = Platforms;
            plat4.transform.parent = Platforms;
            barr1.transform.parent = Barriers;
            trg1.transform.parent = Triggers;
            //barr2.transform.parent = Barriers;
            //Debug.Log("f");*/
            Time.timeScale = 1f;
            //StartCoroutine(LoadingTimer());
            CarClrC.ChooseColor();
        }
    }

    public void ChangeCarSettings()
    {
        //
    }

    public void Win()
    {
        WinPanel.SetActive(true);
        gameWork = false;
    }

    public void GameOver()
    {
        RestartPanel.SetActive(true);
        gameWork = false;
    }

    public void GotoMenu()
    {
        CameraCtrl.lockCursor = false;
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            LoadGameScene();
        }

        if(!gameWork)
        {
            if(Input.GetKeyUp(KeyCode.F))
            {
                Time.timeScale = 0f;
                GotoMenu();
            }
        }
        
    }
    /*IEnumerator LoadingTimer()
    {
        yield return new WaitForSeconds(3);

        Loader.SetActive(false);
    }*/
}