using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class EggCounter : MonoBehaviour
{

    public Text countText;
    public Text levelText;

    private int count;
    private Egg character;

    void Start()
    {
        character = GetComponent<Egg>();
        SetCountText();
        levelText.text = " ";
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Egg"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            print(count);
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 10)
        {
            levelText.text = "10 Eggs - Next Level";

        }

    }

}