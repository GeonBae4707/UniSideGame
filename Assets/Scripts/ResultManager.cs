using UnityEngine;
using UnityEngine.UI;   // 유니티에서 UI를 사용하기 위한 네임스페이스

public class ResultManager : MonoBehaviour
{
    public GameObject scoreText;

    private void Start()
    {
        scoreText.GetComponent<Text>().text = GameManager.totalScore.ToString();
    }
}
