using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] Animator menuAnim;

    public void GoToGameAnimation()
    {
        menuAnim.SetTrigger("ChangeScene");
    }

    public void GoToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}