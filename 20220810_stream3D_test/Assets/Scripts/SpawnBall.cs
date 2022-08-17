using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Alcor 
{
    public class SpawnBall : MonoBehaviour
    {
        [SerializeField, Header("�x�y�w�m��")]
        private GameObject goBasketball;
        private UIElement btnSpawnBasketball;
        private Transform traPlayer;
        private void Awake()
        {
            traPlayer = GameObject.Find("Player").GetComponent<Transform>();
            btnSpawnBasketball = GameObject.Find("�ͦ��x�y").GetComponent<UIElement>();
            btnSpawnBasketball.onHandClick.AddListener((x) => {
                Vector3 pasBall = traPlayer.position + traPlayer.forward * 0.8f + traPlayer.up;
                Instantiate(goBasketball,pasBall,Quaternion.identity); });
        }

    }
}

