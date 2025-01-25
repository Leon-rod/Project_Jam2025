using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text collNumText;
    private int currCollNum = 0;
    public TMP_Text totalCollNumText;
    private int totalCollNum;

    public AudioSource audioSource;
    void Start()
    {
        totalCollNum = transform.childCount;
        totalCollNumText.text = totalCollNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount <= 0)
        {
            Debug.Log("Omedetoh");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }
    }

    public void AddCollectible()
    {
        audioSource.Play();
        currCollNum++;
        collNumText.text = currCollNum.ToString();
    }
}
