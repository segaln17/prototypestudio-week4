using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class WASDController : MonoBehaviour
{
    public static WASDController instance;
    public Rigidbody rb;

    public float walkForce;
    public AudioSource playerAudio;
    public AudioClip ding;

    public AudioSource resetAudio;
    public AudioClip resetding;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * walkForce);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * walkForce);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * walkForce);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * walkForce);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        //CheckLetter();
        if (other.gameObject.tag == "A")
        {
            SpellingScript.instance.wordQueue.Enqueue("A");
            Debug.Log("A");
            SpellingScript.instance.letterText.text = "A";
            playerAudio.PlayOneShot(ding);
        }

        if (other.gameObject.tag == "B")
        {
            SpellingScript.instance.wordQueue.Enqueue("B");
            Debug.Log("B");
            SpellingScript.instance.letterText.text = "B";
            playerAudio.PlayOneShot(ding);
        }

        if (other.gameObject.tag == "C")
        {
            SpellingScript.instance.wordQueue.Enqueue("C");
            Debug.Log("C");
            SpellingScript.instance.letterText.text = "C";
            playerAudio.PlayOneShot(ding);
        }
        
        if (other.gameObject.tag == "D")
        {
            SpellingScript.instance.wordQueue.Enqueue("D");
            SpellingScript.instance.letterText.text = "D";
            playerAudio.PlayOneShot(ding);
            Debug.Log("D");
        }
        
        if (other.gameObject.tag == "E")
        {
            SpellingScript.instance.wordQueue.Enqueue("E");
            Debug.Log("E");
            SpellingScript.instance.letterText.text = "E";
            playerAudio.PlayOneShot(ding);
        }
        
        if (other.gameObject.tag == "F")
        {
            SpellingScript.instance.wordQueue.Enqueue("F");
            SpellingScript.instance.letterText.text = "F";
            playerAudio.PlayOneShot(ding);
            Debug.Log("F");
        }
        
        if (other.gameObject.tag == "G")
        {
            SpellingScript.instance.wordQueue.Enqueue("G");
            SpellingScript.instance.letterText.text = "G";
            playerAudio.PlayOneShot(ding);
            Debug.Log("G");
        }
        
        if (other.gameObject.tag == "H")
        {
            SpellingScript.instance.wordQueue.Enqueue("H");
            SpellingScript.instance.letterText.text = "H";
            playerAudio.PlayOneShot(ding);
            Debug.Log("H");
        }
        
        if (other.gameObject.tag == "I")
        {
            SpellingScript.instance.wordQueue.Enqueue("I");
            SpellingScript.instance.letterText.text = "I";
            playerAudio.PlayOneShot(ding);
            Debug.Log("I");
        }
        
        if (other.gameObject.tag == "J")
        {
            SpellingScript.instance.wordQueue.Enqueue("J");
            SpellingScript.instance.letterText.text = "J";
            playerAudio.PlayOneShot(ding);
            Debug.Log("J");
        }
        
        if (other.gameObject.tag == "K")
        {
            SpellingScript.instance.wordQueue.Enqueue("K");
            SpellingScript.instance.letterText.text = "K";
            playerAudio.PlayOneShot(ding);
            Debug.Log("K");
        }
        
        if (other.gameObject.tag == "L")
        {
            SpellingScript.instance.wordQueue.Enqueue("L");
            SpellingScript.instance.letterText.text = "L";
            playerAudio.PlayOneShot(ding);
            Debug.Log("L");
        }
        
        if (other.gameObject.tag == "M")
        {
            SpellingScript.instance.wordQueue.Enqueue("M");
            SpellingScript.instance.letterText.text = "M";
            playerAudio.PlayOneShot(ding);
            Debug.Log("M");
        }
        
        if (other.gameObject.tag == "N")
        {
            SpellingScript.instance.wordQueue.Enqueue("N");
            SpellingScript.instance.letterText.text = "N";
            playerAudio.PlayOneShot(ding);
            Debug.Log("N");
        }
        
        if (other.gameObject.tag == "O")
        {
            SpellingScript.instance.wordQueue.Enqueue("O");
            SpellingScript.instance.letterText.text = "O";
            playerAudio.PlayOneShot(ding);
            Debug.Log("O");
        }
        
        if (other.gameObject.tag == "P")
        {
            SpellingScript.instance.wordQueue.Enqueue("P");
            SpellingScript.instance.letterText.text = "P";
            playerAudio.PlayOneShot(ding);
            Debug.Log("P");
        }
        
        if (other.gameObject.tag == "Q")
        {
            SpellingScript.instance.wordQueue.Enqueue("Q");
            SpellingScript.instance.letterText.text = "Q";
            playerAudio.PlayOneShot(ding);
            Debug.Log("Q");
        }
        
        if (other.gameObject.tag == "R")
        {
            SpellingScript.instance.wordQueue.Enqueue("R");
            SpellingScript.instance.letterText.text = "R";
            playerAudio.PlayOneShot(ding);
            Debug.Log("R");
        }
        
        if (other.gameObject.tag == "S")
        {
            SpellingScript.instance.wordQueue.Enqueue("S");
            SpellingScript.instance.letterText.text = "S";
            playerAudio.PlayOneShot(ding);
            Debug.Log("S");
        }
        
        if (other.gameObject.tag == "T")
        {
            SpellingScript.instance.wordQueue.Enqueue("T");
            SpellingScript.instance.letterText.text = "T";
            playerAudio.PlayOneShot(ding);
            Debug.Log("T");
        }
        
        if (other.gameObject.tag == "U")
        {
            SpellingScript.instance.wordQueue.Enqueue("U");
            SpellingScript.instance.letterText.text = "U";
            playerAudio.PlayOneShot(ding);
            Debug.Log("U");
        }
        
        if (other.gameObject.tag == "V")
        {
            SpellingScript.instance.wordQueue.Enqueue("V");
            SpellingScript.instance.letterText.text = "V";
            playerAudio.PlayOneShot(ding);
            Debug.Log("V");
        }
        
        if (other.gameObject.tag == "W")
        {
            SpellingScript.instance.wordQueue.Enqueue("W");
            SpellingScript.instance.letterText.text = "W";
            playerAudio.PlayOneShot(ding);
            Debug.Log("W");
        }
        
        if (other.gameObject.tag == "X")
        {
            SpellingScript.instance.wordQueue.Enqueue("X");
            SpellingScript.instance.letterText.text = "X";
            playerAudio.PlayOneShot(ding);
            Debug.Log("X");
        }
        
        if (other.gameObject.tag == "Y")
        {
            SpellingScript.instance.wordQueue.Enqueue("Y");
            SpellingScript.instance.letterText.text = "Y";
            playerAudio.PlayOneShot(ding);
            Debug.Log("Y");
        }
        
        if (other.gameObject.tag == "Z")
        {
            SpellingScript.instance.wordQueue.Enqueue("Z");
            SpellingScript.instance.letterText.text = "Z";
            playerAudio.PlayOneShot(ding);
            Debug.Log("Z");
        }

        if (other.gameObject.tag == "Reset")
        {
            playerAudio.PlayOneShot(resetding);
            SpellingScript.instance.wordQueue.Clear();
            Debug.Log("RESET");
        }
        //Debug.Log("hit something");
    }
    
}
