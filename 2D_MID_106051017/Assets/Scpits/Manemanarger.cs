using UnityEngine;
using UnityEngine.SceneManagement;

public class Manemanarger : MonoBehaviour
{
    public void StartGmae ()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡1");
    } 

    public void QuitGmae ()
    {

        print("結束遊戲");
        Application.Quit();
    }
}
