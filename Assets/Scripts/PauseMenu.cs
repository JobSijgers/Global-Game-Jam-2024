using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private Slider slider;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActivatePauseMenu();
        }
    }
    public void ActivatePauseMenu()
    {
        if (_pauseMenu.activeInHierarchy)
        {
            _pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        else if (!_pauseMenu.activeInHierarchy)
        {
            _pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void GetValue()
    {
        GameManager.Instance.ApplyAudio(slider.value);
    }
    public void Exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}
