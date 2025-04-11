using UnityEngine;
using UnityEngine.UI;

public class DeteksiAsteroid : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    void Start()
    {
        Score.score = 0;
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;

        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            Score.score += 10;
            textScore.text = Score.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {

            Score.score -= 5;
            textScore.text = Score.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }


    }



    void Update()
    {
        
    }
}
