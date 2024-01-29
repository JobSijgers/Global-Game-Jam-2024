using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject _credits;
    [SerializeField] private GameObject _options;
    [SerializeField] private Slider slider;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMenus();
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Credits()
    {
        ActivateMenu();
    }
    public void Options()
    {
        ActivateOptions();
    }
    public void GetValue()
    {
        GameManager.Instance.ApplyAudio(slider.value);
    }
    private void ActivateMenu()
    {
        if (!_credits.activeInHierarchy)
        {
            _credits.SetActive(true);
        }
        else if (_credits.activeInHierarchy)
        {
            _credits.SetActive(false);
        }
    }
    private void ActivateOptions()
    {
        if (!_options.activeInHierarchy)
        {
            _options.SetActive(true);
        }
        else if (_options.activeInHierarchy)
        {
            _options.SetActive(false);
        }
    }
    private void CloseMenus()
    {
        if (_options.activeInHierarchy)
        {
            _options.SetActive(false);
        }
        else if (_credits.activeInHierarchy)
        {
            _credits.SetActive(false);
        }
    }
}
