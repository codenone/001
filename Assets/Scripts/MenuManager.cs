using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    #region external-methods
    public void LoadLevel(int level)
    {
        Application.LoadLevel(level);
    }

    public void Exit()
    {
        Application.Quit();
    }
    #endregion
}
