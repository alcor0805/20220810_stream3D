using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

namespace Alcor
{
    public class SceneControll : MonoBehaviour
    {
        private UIElement uiReplay;
        private UIElement uiQuit;
        private string nameSceneToReplay = "basketball";
        private void Awake()
        {
            uiReplay= GameObject.Find("���s�}�l").GetComponent<UIElement>();
            uiQuit= GameObject.Find("���}�C��").GetComponent<UIElement>();
            uiReplay.onHandClick.AddListener((UnityAction)=> { SceneManager.LoadScene(nameSceneToReplay); });
            uiReplay.onHandClick.AddListener((UnityAction)=> { Application.Quit(); });

        }
    }
}

