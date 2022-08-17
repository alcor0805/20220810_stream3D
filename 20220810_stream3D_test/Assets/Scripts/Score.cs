using TMPro;
using UnityEngine;
namespace Alcor
{
    public class Score : MonoBehaviour
    {

        private string nameBasketball = "Äx²y";
        private TextMeshProUGUI textScore;
        private static int addScore = 2;
        private int totalScore;
        private void Awake()
        {
            textScore = GameObject.Find("¤À¼Æ").GetComponent<TextMeshProUGUI>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.name == nameBasketball)
            {
                AddScore();
            }
        }
        private void AddScore()
        {
            totalScore += addScore;
            textScore.text = "Score: " + totalScore;
        }
    }
}

