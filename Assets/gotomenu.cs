using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gotomenu : MonoBehaviour {

    // planecontroller a;
    public Button myButton;
    private void Start()
    {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
