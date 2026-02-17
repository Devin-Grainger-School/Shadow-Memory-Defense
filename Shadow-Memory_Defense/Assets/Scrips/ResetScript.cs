using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    public void ResetGame()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
