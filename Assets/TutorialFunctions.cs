using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class TutorialFunctions : MonoBehaviour
{
    Scene currentScene;
    public TMP_Text tutorialText;
    public GameObject introPanel;
    public GameObject t;//track
    public GameObject c; //carb
    public GameObject s; //speaking textbox
    public GameObject gb1;
    public GameObject gb2;
    public GameObject hurdle;
    public GameObject blueBox;
    public GameObject blackBox;
    public GameObject playButton;
    public GameObject homeButton;
    public GameObject backButton;
    public GameObject nextButton;

    public Collider2D carbCarl;
    public GameObject trackCarb;
    public Rigidbody2D rigid;
    [SerializeField] private LayerMask PlatformLayerMask;

    bool g1 = true;
    bool g2 = true;
    bool bb = true;
    bool black = true;
    bool move;
    int speed = 5;
    private float boostTimer;

    int tutorialSeq = 0;

    private void Awake()
    {

        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {

            case "02TutorialScene":
                InitializeTutorial();
                break;

        }
    }



        void InitializeTutorial()
        {
            Debug.Log("I am here");
            introPanel.SetActive(true);
            t.SetActive(false);
            s.SetActive(false);
            c.SetActive(false);
            gb1.SetActive(false);
            gb2.SetActive(false);
            playButton.SetActive(false);
            homeButton.SetActive(false);
            blueBox.SetActive(false);
        blackBox.SetActive(false);
            hurdle.SetActive(false);
        }

         public void startTutorial()
        {

            introPanel.SetActive(false);
            t.SetActive(true);
            s.SetActive(true);
            c.SetActive(true);
        homeButton.SetActive(true);
        tutorialText.text = "Hi! Carb Carl here to teach you about carbohydrates and energy! You first need to learn some controls.";
            nextButton.SetActive(true);
        }

        public void TutSequenceBack()
        {
            tutorialSeq -= 2;
            TutorialNext();
        }

         public void TutorialNext()
        {
            tutorialSeq++;
            switch (tutorialSeq)
            {
                case 0:
                    startTutorial();
                    break;
                case 1:
                    tutorialText.text = "How this is going to work is we are going to first learn about healthy carbohydrates and use that to give us a boost at the race.";
                homeButton.SetActive(false);
                    backButton.SetActive(true);
                    break;

                case 2:
                    tutorialText.text = "As for the race, we are going to do a little practice right now.";
                    nextButton.SetActive(true);
                    break;
                case 3:
                    tutorialText.text = "We are first going to learn how to move. Use your right and left arrow keys to move me to both of the green squares.";
                    move = true;
                    nextButton.SetActive(false);
                    gb1.SetActive(true);
                    gb2.SetActive(true);
                    g1 = true;
                    g2 = true;
                    break;
                case 4:
                    tutorialText.text = "Nice Job! Next thing you need to know is how to jump a hurdle";
                g1 = true;
                g2 = true;
                nextButton.SetActive(true);
                    break;
                case 5:
                    tutorialText.text = "To jump, use the up arrow key. Now run over to the hurdle, jump over it and hit the blue square.";
                speed = 2;
                    hurdle.SetActive(true);
                    blueBox.SetActive(true);
                    bb = true;
                    nextButton.SetActive(false);
                    break;
                case 6:
                    tutorialText.text = "Fantastic! We are almost done. The last think you need to know about are the boosts.";
                hurdle.SetActive(false);
                nextButton.SetActive(true);
                    break;
                case 7:
                    tutorialText.text = "Boosts are bursts of energy that you can use during a track meet. You can earn boosts by getting questions right at the quiz part of the game.";
                nextButton.SetActive(true);
                break;
                case 8:
                    tutorialText.text = "These boosts last for a period of time. To activate a boost, press the space bar. Now use a boost to get to the black square.";
                    blackBox.SetActive(true);
                    nextButton.SetActive(false);
                    black = true;
                    break;
            case 9:
                tutorialText.text = "Good work! Now its time to head over to the game. See ya there!";
                nextButton.SetActive(false);
                playButton.SetActive(true);
                homeButton.SetActive(true);
                backButton.SetActive(false);
                break;



        }

        }

        // Update is called once per frame
        void Update()
        {
            if (carbCarl.IsTouching(gb1.GetComponent<Collider2D>()))
            {
                gb1.SetActive(false);
                g1 = false;
            }
            if (carbCarl.IsTouching(gb2.GetComponent<Collider2D>()))
            {
                gb2.SetActive(false);
                g2 = false;
            }
            if (!g1 && !g2)
            {
            Vector3 pos;
            pos = trackCarb.transform.position;
            pos.x = -120;
            //trackCarb.transform.position = pos;

                TutorialNext();
            }
            if (carbCarl.IsTouching(blueBox.GetComponent<Collider2D>()))
            {
                blueBox.SetActive(false);
            TutorialNext();
        }
            if (!bb)
            {
            Vector3 p;
            p = trackCarb.transform.position;
            p.x = -120;
            trackCarb.transform.position = p;
            TutorialNext();

            }
            if (carbCarl.IsTouching(blackBox.GetComponent<Collider2D>()))
            {
                blackBox.SetActive(false);
            TutorialNext();
        }
            if (!black)
            {
            Vector3 po;
            po = trackCarb.transform.position;
            po.x = -120;
            trackCarb.transform.position = po;
            TutorialNext();

            }

        if (move)
            {
                
                    if (Input.GetKey(KeyCode.LeftArrow))
                    {
                        Debug.Log("Move left");
                        Vector3 position = trackCarb.transform.position;
                        position.x -= speed;
                        trackCarb.transform.position = position;

                    }
                
                if (Input.GetKey(KeyCode.RightArrow))
                {

                    Vector3 position = trackCarb.transform.position;
                    position.x += speed;
                    trackCarb.transform.position = position;

                }

                if (isGrounded() && Input.GetKey(KeyCode.UpArrow))
                {
                    float jumpVelocity = 200f;
                    rigid.velocity = Vector2.up * jumpVelocity;
                }


                if (Input.GetKeyDown(KeyCode.Space))
                {
                    
                        speed+=3;
                        
                        boostTimer += Time.deltaTime;
                        if (boostTimer >= 1)
                        {
                            speed--;
                            boostTimer = 0;
                        }
                        

                    }
                }
            }

        private bool isGrounded()
        {
            RaycastHit2D raycast = Physics2D.BoxCast(carbCarl.bounds.center, carbCarl.bounds.size, 0f, Vector2.down, .1f, PlatformLayerMask);
            //Debug.Log(raycast.collider);
            return raycast.collider != null;

        }
    
    }

