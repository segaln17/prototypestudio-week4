using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class SpellingScript : MonoBehaviour
{
    public static SpellingScript instance;
    public Queue<string> wordQueue = new Queue<string>();

    public GameObject player;

    //the word you spell
    public TextMeshProUGUI spelledWord;

    public TextMeshProUGUI debugWord;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI letterText;
    
    //the word you're trying to spell
    public string goalWord;
    public List<string> goalWordList = new List<string>();
    
    private float timer = 0;

    public float timeLeft = 5f;
    public float timeLeftInitial = 45f;

    public int score = 0;
    
    public bool isSpelling = false;

    public Animator endBanner;
    public Animator trophy;

    public Image endBannerImage;
    public Image trophyImage;

    public GameObject endParticles;

    public AudioSource audioHolder;
    public AudioClip cheering;

    public AudioSource wordAudioHolder;
    public AudioClip yourWordIs;
    public AudioClip correct;
    public AudioClip incorrect;
    public AudioClip rhinoceros;
    public AudioClip mom;
    public AudioClip gmail;
    public AudioClip loser;
    public AudioClip pandemonium;
    public AudioClip hospital;
    public AudioClip swimming;
    public AudioClip banana;
    public AudioClip bendy;
    public AudioClip splice;
    
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    void Start()
    {
        endBannerImage.gameObject.SetActive(false);
        trophyImage.gameObject.SetActive(false);
        //goalWordList.Add("splice");
        //goalWordList.Add("bendy");
        
        goalWordList.Add("pandemonium");
        //goalWordList.Add("rhinoceros");
        goalWordList.Add("hospital");
        goalWordList.Add("banana");
        //goalWordList.Add("swimming");
        goalWordList.Add("loser");
        goalWordList.Add("gmail");
        
        goalWordList.Add("mom");

        //goalWord = randomWordList[0].ToString();
        StartCoroutine(ReadyToSpell());
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpelling)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time left: " + Mathf.RoundToInt(timeLeft);
            //Debug.Log(timeLeft);
            if (timeLeft <= timer)
            {
                isSpelling = false;
                DoneSpelling();
            }

        }

        /* THIS DOES NOT WORK: IT DOES NOT RELOAD EVERYTHING ELSE
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("SpellingScene");
        }
        */
    }

    IEnumerator ReadyToSpell()
    {
        yield return new WaitForSeconds(1f);
        wordAudioHolder.PlayOneShot(yourWordIs);
        goalWord = goalWordList[Random.Range(0, goalWordList.Count)];
        yield return new WaitForSeconds(2f);
        if (goalWord == "rhinoceros")
        {
            wordAudioHolder.PlayOneShot(rhinoceros);
        }

        if (goalWord == "gmail")
        {
            wordAudioHolder.PlayOneShot(gmail);
        }

        if (goalWord == "mom")
        {
            wordAudioHolder.PlayOneShot(mom);
        }
        
        if (goalWord == "loser")
        {
            wordAudioHolder.PlayOneShot(loser);
        }

        if (goalWord == "pandemonium")
        {
            wordAudioHolder.PlayOneShot(pandemonium);
        }

        if (goalWord == "swimming")
        {
            wordAudioHolder.PlayOneShot(swimming);
        }

        if (goalWord == "banana")
        {
            wordAudioHolder.PlayOneShot(banana);
        }

        if (goalWord == "hospital")
        {
            wordAudioHolder.PlayOneShot(hospital);
        }

        if (goalWord == "splice")
        {
            wordAudioHolder.PlayOneShot(splice);
        }

        if (goalWord == "bendy")
        {
            wordAudioHolder.PlayOneShot(bendy);
        }
        yield return new WaitForSeconds(0.5f);
        debugWord.text = goalWord;
        spelledWord.text = "";
        //play audioclip
        Debug.Log("ready to spell");
        Debug.Log("your word is" + goalWord);
        timeLeft = timeLeftInitial;
        yield return new WaitForSeconds(0.5f);
        isSpelling = true;
    }
    
    private void ShowQueue()
    {
        //while there are things in the queue, take them out and display them
        while (wordQueue.Count > 0)
        {
            spelledWord.text += wordQueue.Dequeue();
        }
    }
    
    public void DoneSpelling()
    {
        ShowQueue();
        //switch camera view to see the other side of the stage?
        //check if the word is right or wrong
        if (spelledWord.text == goalWord.ToUpper())
        {
            wordAudioHolder.PlayOneShot(correct);
            score++;
            Debug.Log("correct!");
            StartCoroutine(ChangeWord());
        }
        
        else
        {
            wordAudioHolder.PlayOneShot(incorrect);
            Debug.Log("wrong");
            StartCoroutine(ChangeWord());
        }
        //play an animation and an audioclip
        
    }
    

    IEnumerator ChangeWord()
    {
        if (goalWordList.Count != 0)
        {
            goalWordList.Remove(goalWord);
            yield return new WaitForSeconds(1.5f);
            //play audioclip of yes or no
            Debug.Log("Next word!");
            yield return new WaitForSeconds(2f);
            letterText.text = "";
            StartCoroutine(ReadyToSpell());
            //isSpelling = true;
        }
        if(goalWordList.Count <= 0)
        {
            spelledWord.text = "THAT'S IT!";
            wordAudioHolder.gameObject.SetActive(false);
            StartCoroutine(WaitAnimate());
            Debug.Log(score);
            letterText.text = "FINAL SCORE: " + "\n" + score;
        }
        
    }

    IEnumerator WaitAnimate()
    {
        yield return new WaitForSeconds(0.5f);
        endBannerImage.gameObject.SetActive(true);
        trophyImage.gameObject.SetActive(true);
        Instantiate(endParticles, player.transform.position, player.transform.rotation);
        audioHolder.PlayOneShot(cheering);
        endBanner.Play("End Animation");
        trophy.Play("Trophy");
    }

}
