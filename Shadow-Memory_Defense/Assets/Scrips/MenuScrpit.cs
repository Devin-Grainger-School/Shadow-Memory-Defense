using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScrpit : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

}