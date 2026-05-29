using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player; //æÕ≈“°player„ Ë°Á®– “¡“√∂‡¢È“∂÷ßµ”·ÀπËßplayer‰¥È
    public TextMeshProUGUI scoretext;

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "player2" + player.position;
    }
}
