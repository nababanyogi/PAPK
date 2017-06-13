
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour {
    public GameObject setting;
    public GameObject menu;
    public GameObject creditBy;
	public GameObject pause;

	// Use this for initialization
	void Start () {
        menu.SetActive(true);
        setting.SetActive(false);
        creditBy.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartGameClicked(int ketujuan)
    {
        Application.LoadLevel(ketujuan);
    }
    public void SettingClicked()
    {
        setting.SetActive(true);
        menu.SetActive(false);
        creditBy.SetActive(false);
    }
    public void CreditByClicked()
    {
        creditBy.SetActive(true);
        menu.SetActive(false);
        setting.SetActive(false);
    }
     public void BackToMenuClicked()
    {
        menu.SetActive(true);
        setting.SetActive(false);
        creditBy.SetActive(false);

    }
    public void QuitGameClicked()
    {
        Application.Quit();
    }
	public void pauseGameClicked()
	{
		Time.timeScale = 0;
		pause.SetActive (true);
	}	
}
