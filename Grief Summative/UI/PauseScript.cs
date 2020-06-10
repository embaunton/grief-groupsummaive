using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;

    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            SoundManagerScript.PlaySound("Select");
        }

      if (isPaused)
        {
            ActivateMenu();
        }

      else
        {
            DeactivateMenu();
        }

    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

}
