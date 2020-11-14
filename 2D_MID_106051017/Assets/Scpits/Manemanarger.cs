using UnityEngine;

public class Manemanarger : MonoBehaviour
{
    public void StartGmae ()
    {
        print("開始遊戲");
    } 

    public void QuitGmae ()
    {

        print("結束遊戲");
        Application.Quit();
    }
}
