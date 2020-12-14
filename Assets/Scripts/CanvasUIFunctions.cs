using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class CanvasUIFunctions : MonoBehaviour
{
    Scene currentScene;
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public TMP_Text introText;
    public TMP_Text lvlOneText;
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    
    [Header("Level 1 Scene Properties", order = 2)]
    public GameObject carb;
    public GameObject SpeechBubble;
    public GameObject QuizPanel;
    public GameObject PlayGameButton;
    public TMP_Text QuestionText;
    public TMP_Text TextA;
    public TMP_Text TextB;
    public TMP_Text TextC;
    public TMP_Text TextD;
    public TMP_Text PwrUpScore;
    public TMP_Text ResultText;
    public TMP_Text Countdown;
    public TMP_Text Output;
    public GameObject Instructions;
    public Collider2D startLine;
    public Collider2D carbCarl;
    //public Rigidbody2D carl;
    public GameObject trackCarb;
    public GameObject trackObjects;
    public GameObject QuizGame;
    public GameObject cake, icecream;
    public GameObject resultsPanel;
    public GameObject track;
    public Collider2D topLine;
    public Collider2D bottomLine;
    public GameObject panel;
    public Rigidbody2D rigid;
    [SerializeField] private LayerMask PlatformLayerMask;
    public Collider2D Hurdle1;
    public Collider2D Hurdle2;
    public Collider2D Hurdle3;
    public GameObject Finish;
    public TMP_Text output;
    public TMP_Text Des;
    public float forceAmount = 100f;

    public bool move = false;
    bool touching = false;
    bool touchingTop = false;
    bool touchingBottom = false;
    float speed = 0.5f;
    int powerups = 0;
    private float boostTimer;


    int q1, q2, q3; // question numbers
    int qCount; // count of what question you are on
    int[] questions = new int[3]; // array to hold question numbers
   
    int introSequence;
    int lvlOneSeq;
    int score = 2;
    

    private void Awake()
    {
        boostTimer = 0;
        //rb = GetComponent<Rigidbody>();
        currentScene = SceneManager.GetActiveScene();
        switch (currentScene.name)
        {
            case "00TitleScene":
                break;
            case "01IntroScene":
                InitializeIntro();
                break;
            case "02TutorialScene":
                break;
            case "03LevelOneScene":
                InitializeLvlOne();
                break;
        }
    }

    void InitializeIntro()
    {
        introText.fontSize = 36;
        introText.horizontalAlignment = HorizontalAlignmentOptions.Center;
        introText.text = "Welcome to the Breakfast Club!\n\n" + "Play fun games to learn about essential food groups";
        introImage.SetActive(true);
        backButton.SetActive(false);
        nextButton.SetActive(true);
    }

    

    void InitializeLvlOne()
    {
        carb.SetActive(true);
        //panel.GetComponent<Image>().color = new Color(0.9921f, 0.7653f, 0.1686f);
        trackObjects.SetActive(false);
        ResultText.text = "";
        setQNums();
        Debug.Log("IM HERE");
        nextButton.SetActive(true);
        QuizPanel.SetActive(false);
        QuizGame.SetActive(false);
        Instructions.SetActive(false);
        
        //carb.gameObject.transform.position = new Vector3(-251f, -182f, 0f);
        SpeechBubble.SetActive(true);
        backButton.SetActive(false);
        lvlOneText.fontSize = 40;
        lvlOneText.text = "Hi! My name is Carb Carl and I am here to teach you about Carbohydrates!";
    }

    public void IntroSequenceNext()
    {
        introSequence++;
        switch (introSequence)
        {
            case 0:
                backButton.SetActive(false);
                InitializeIntro();
                break;

            case 1:
                introText.fontSize = 36;
                introText.horizontalAlignment = HorizontalAlignmentOptions.Left;
                introText.text = "OVERVIEW\n\n"
                    + "Title: The Breakfast Club\n"
                    + "Platform: WebGL Build\n"
                    + "Subject: Science\n"
                    + "Sub Subject: Nutritional Science\n"
                    + "\nMain Focus: Nutrition\nLearning Level: Grades 5-8";
                introImage.SetActive(false);
                backButton.SetActive(true);
                break;
            case 2:
                introText.fontSize = 30;
                introText.text = "\nPROPOSED EDTECH SOLUTION\n\n"
                    + "Healthy eating is essential for all people and though there are initiatives to teach benefits of healthy eating,"
                    + "it continues to affect everyone everywhere. "
                    + "The best way to have people know the benefits of healthy eating is for it to be taught at a young age. "
                    + "In order for children to know the importance of eating well and the detrimental effects of not having a good diet, "
                    + "I think it is crucial to teach in an entertaining manner. "
                    + "So, I propose having an interactive experience where the user learns about all the food groups that they should eat "
                    + "and also be taken on adventures through the body to see what each group does for the body.";
                break;
            case 3:
                introText.fontSize = 23;
                introText.text = "\nCOMPETING SOFTWARE REVIEW\n\n"
                    + "Blast Off – This is a game that makes the user choose what they will eat for the day and place their foods in the respective food groups. When choosing the foods, the nutrition facts show up and a meter shows how much of food group you have. Also, there is a calorie meter and physical activity meter which all work together to determine if the user can blast off. \n"
                    + "Health-Nutrition – This application is an eLearning tool for learning the food pyramid. The tool teaches the food group as well as associating different foods with their respective categories. There is a space theme to the experience where the user flies to different “meal planets” and in order to do so they need to select the healthy food.\n"
                    + "MyPlateMatch Game - This game is made for children to learn about MyPlate. MyPlate is a diagram made by the government to teach kids healthy eating. The user first starts off matching the plate categories into the right spot. They then categorize different foods and choose activities to get the right amount of physical activity.";
                break;
            case 4:
                introText.fontSize = 20;
                introText.text = "\nCOMPETING SOFTWARE SUGGESTING IMPROVEMENTS\n\n"
                    + "Relevance – One of the technologies that I used ( Health Nutrition ) was teaching the health pyramid. This is an outdated graphic and concept, so there should be activities that portray the more relevant information that is recommended by nutritionists today. To make the experience more relevant I would include mini games that represent 6 food groups that nutritionists recommend.\n"
                    + "More insightful information – The competing software all exhibit the same kind of information. They all give insight into what the kids should eat but not why. The calories and energy that they show will not incentivize kids as much to eat healthy. Instead, they should offer information what happens in the body when different types of food are eaten. This way kids will know what happens to their bodies when they eat different foods and makes a more personal connection to them. To include this, the mini games will demonstrate the effects of healthy food on the body.\n"
                    + "Interactivity – The competing software all had some element of interactivity but not enough to keep a kid’s attention. In order to counter the possibility of the user getting bored, there should be more to interact with. Having an element of adventure or a timer makes a game more of a challenge than just practice. In the same sense, I want to have mini games to represent each food group that are informational but also provide a challenge. For example, there would be a carbohydrate game that demonstrates that carbs give energy. The game would be a racing game where picking the right carbohydrate food would make the player faster.";
                break;
            case 5:
                introText.fontSize = 36;
                introText.text = "STAKEHOLDERS\n\n"
                    + "Teachers\n"
                    + "Parents\n"
                    + "Dietitians\n\n"
                    + "USERS: Students in grades 5-8";
                break;
            case 6:
                introText.fontSize = 25;
                introText.text = "PERSONA\n\n"
                    + "Name: Wilson\n"
                    + "Age: 14 years old\n"
                    + "Gender: Male\n"
                    + "Location: Suburbia USA\n"
                    + "Personal Notes:\n"
                    + "    •	Tried out for track and field once and didn’t make it\n"
                    + "    •	Likes to stay inside and play video games\n"
                    + "    •	Likes to eat fast food and snacks on junk food\n"
                    + "Student Notes:\n"
                    + "    •	Rarely thinks about the consequences of what he eats\n"
                    + "    •	Does not retain information taught lecture style\n"
                    + "    •	Has only vaguely learned “myPlate” in health class\n"
                    + "    •	Likes to learn from hands-on activities";
                break;
            case 7:
                introText.fontSize = 30;
                introText.text = "PERSONA JUSTIFICATION\n\n"
                    + "After completing the initial phase of research, I have chosen a persona named Wilson. Wilson represents a male middle school student who would use this application. He mirrors a child in middle school who would rather play a game than learn from a lecture. He needs to learn from activities that are more engaging and interactive to retain and process information. I chose this persona because this is around this age where children start to make their own decisions and have a say in what they should eat. They will better retain this information at this age. ";
                break;
            case 8:
                introText.fontSize = 25;
                introText.text = "PROBLEM SCENARIO\n\n"
                    + "Wilson is a 12-year-old with a fascination with track and field. He loves sports in general but never has been the best in them. He enjoys watching and would love to play but his stamina and eating habits are not on par with what they should be. He had learned about the myPlate diagram last year, but he did not understand what those foods did for him. He was not engaged so he just ended up memorizing the food plate for his exam and never took into consideration that he could use it to become a better athlete. "
                    + "\nOne day, Wilson finds out that the school track and field team is holding try-outs and he decides to go. Wilson ends up being cut and is discouraged from participating in any sports. He then decides to play video games more often and cut down on the time he played any sports or training to try out again. ";
                break;
            case 9:
                introText.text = "ACTIVITY SCENARIO\n\n"
                    + "One day at school, Wilson attends his health class and learns that they are beginning to teach the nutrition section. Wilson starts to feel annoyed as he remembers this section to be boring in last year’s health class. He dreads watching outdated videos and learning to memorize the food plate diagram. He had never paid attention to his diet and never realized how big a part it plays in being a better athlete. To his surprise, the homework that the teacher assigned was to play a game and write what he learned from it. Excited that he gets to play a game for homework, Wilson is eager to start his homework. ";
                break;
            case 10:
                introText.text = "ACTIVITY SCENARIO CONTINUED\n\n"
                    + "After completing all of the levels in the game, Wilson ends up learning all the different food groups that are essential for the body. Seeing how each of them affects the body motivates Wilson to start to eat healthier foods from those food groups to see if he can tell the differences that the game mentioned. He was also inspired to begin his training again but this time with healthy eating habits that take his training to the next level. He begins to notice that he has more energy and speed. Playing the game makes Wilson realize what effects these foods have on the body and the benefits of eating them. He then decides that he wants to incorporate the healthy eating into his everyday lifestyle.";
                nextButton.SetActive(true);
                break;
            case 11:
                introText.text = "PROBLEM STATEMENT\n"
                    + "\nWilson is bored and not interested in the way nutrition is taught in school. He does not learn well from reading infographics or from lectures. He never really knew the importance of eating healthy, he knew that it was a good thing to do but not why. Learning about the different essential groups in an interactive way shows Wilson the effects they have on the body and why they are necessary to lead a healthy life. This game breaks down the different groups into mini games where the essence of the group is delivered through the game Wilson plays. Having an interactive assignment is what helps Wilson concentrate and learn at the same time. He is able to relate the information that he learns in the interactive game to his real life.";
                nextButton.SetActive(false);
                break;
        }
    }

    public void IntroSequenceBack()
    {
        introSequence -= 2;
        IntroSequenceNext();
    }

   

    public void OneSequenceBack()
    {
        lvlOneSeq -= 2;
        LevelOneNext();
    }

    public void LevelOneNext()
    {
        lvlOneSeq++;
        switch (lvlOneSeq)
        {
            case 0:
                InitializeLvlOne();
                break;
            case 1:
                //lvlOneText.transform.position = new Vector3(200.0f, 187.0f, 0.0f);
                lvlOneText.text = "I have a track meet to get to but before that here are some facts about carbohydrates and healthy eating that will help us!";
                backButton.SetActive(true);
                break;
            case 2:
                //lvlOneText.transform.position = new Vector3(206.0f, 138.0f, 0.0f);
                lvlOneText.text = "Healthy eating is very important to keep us in the best shape we can be!";
                break;
            case 3:
                lvlOneText.text = "There are many perks to healthy eating such as more energy, disease prevention, and better mood.";
                break;
            case 4:
                lvlOneText.text = "Not eating healthy could lead to feeling tired, feeling weak, and not being your best self!";
                break;
            case 5:
                lvlOneText.text = "There are 6 essential food groups that you should eat foods from everyday! Each of them provide different benefits for the body";
                break;
            case 6:
                lvlOneText.text = "We are going to call these food groups nutrients, so we are not talking about the foods themselves but more what is IN them";
                break;
            case 7:
                lvlOneText.text = "Nutrients are substances that the body uses to perform its functions. They are split into MICRONUTRIENTS and MACRONUTRIENTS";
                break;
            case 8:
                lvlOneText.fontSize = 35;
                lvlOneText.text = "So like the name suggests, micronutrients are nutrients that the body needs in small amounts, and macronutrients are nutrients that they body needs in large amounts";
                break;
            case 9:
                lvlOneText.fontSize = 40;
                //lvlOneText.transform.position = new Vector3(1.0f, 13.5f, 0.0f);
                lvlOneText.text = "So right now we are going to cover one of the macronutrients, which are Carbohydrates! Like me!";
                break;
            case 10:
                lvlOneText.text = "Carbohydrates are your body's main source of ENERGY! They fuel your body and organs ";
                break;
            case 11:
                lvlOneText.fontSize = 38;
                lvlOneText.text = "They create energy by breaking down the carbs in your food into simple sugars, these sugars are then absorbed into the blood stream and used as energy";
                break;
            case 12:
                lvlOneText.fontSize = 45;
                lvlOneText.text = "But... NOT ALL CARBOHYDRATES ARE GOOD!";
                break;
            case 13:
                lvlOneText.fontSize = 37;
                lvlOneText.text = "There are simple carbohydrates such as table sugar, soda and baked goods that have sugar, but are NOT good for you.";
                break;
            case 14:
                lvlOneText.fontSize = 37;
                lvlOneText.text = "These carbs digest faster and do not give you stable source of energy. They may give you energy for a short amount of time but it won't last long.";
                break;
            case 15:
                lvlOneText.text = "On the other hand, we have complex carbohydrates which are foods such as brown rice, oats, and beans. ";
                break;
            case 16:
                lvlOneText.text = "Complex carbohydrates break down slower and provide you with more sustainable energy that won't make you crash";
                break;
            case 17:
                lvlOneText.fontSize = 40;
                //lvlOneText.transform.position = new Vector3(1.0f, 13.8f, 0.0f);
                lvlOneText.text = "Now that we know all about carbohydrates let's use what we learned to help me at the track meet! ";
                break;
            case 18:
                lvlOneText.fontSize = 38;
                //lvlOneText.transform.position = new Vector3(-0.2f, 21.7f, 0.0f);
                lvlOneText.text = "I will ask you a series of questions about what we just learned, and based on your answers, you will get a certain amount of powerups to use during the track game";
                break;
            case 19:
                lvlOneText.fontSize = 42;
                //lvlOneText.transform.position = new Vector3(1.3f, 12.5f, 0.0f);
                lvlOneText.text = "Don't worry too much about getting them all right. You will have a chance to try again! ";
                break;
            case 20:
                Quiz();
                break;
        }
        
    }

    public void setQNums ()
    {
        q1 = (int)Random.Range(1.0f, 8.0f);
        q2 = (int)Random.Range(1.0f, 8.0f);
        while (q2 == q1)
        {
            q2 = (int)Random.Range(1.0f, 8.0f);
        }
        q3 = (int)Random.Range(1.0f, 8.0f);
        while (q3 == q2 || q3 == q1)
        {
            q3 = (int)Random.Range(1.0f, 8.0f);
        }
        questions[0] = q1;
        questions[1] = q2;
        questions[2] = q3;
        
    }

    public void Quiz()
    {
        QuizPanel.SetActive(true);
        QuizGame.SetActive(true);
        PlayGameButton.SetActive(false);
        backButton.SetActive(false);
        nextButton.SetActive(false);
        SpeechBubble.SetActive(false);
        //carb.gameObject.transform.position = new Vector3(-261f, -43f, 0f);



        //int[] questions = { q1, q2, q3 };


        if (qCount < 4)
        {
            switch (questions[qCount])
            {
                case 1:
                    QuestionText.text = "Carbohydrates are the body's main source of...";
                    TextA.text = "Fat";
                    TextB.text = "Energy";
                    TextC.text = "Calories";
                    TextD.text = "Vitamins";
                    GameObject.Find("ButtonB").tag = "Correct";
                    
                    break;
                case 2:
                    QuestionText.text = "How many essential nutrients are there?";
                    TextA.text = "6";
                    TextB.text = "4";
                    TextC.text = "9";
                    TextD.text = "2";
                    GameObject.Find("ButtonA").tag = "Correct";
                    
                    break;
                case 3:
                    QuestionText.text = "Nutrients split into the categories of...";
                    TextA.text = "Micronutrients";
                    TextB.text = "Macronutrients";
                    TextC.text = "Meganutrients";
                    TextD.text = "A and B";
                    GameObject.Find("ButtonD").tag = "Correct";
                    break;
                case 4:
                    QuestionText.text = "Baked goods often contain _______ carbohydrates.";
                    TextA.text = "complex";
                    TextB.text = "double";
                    TextC.text = "simple";
                    TextD.text = "basic";
                    GameObject.Find("ButtonC").tag = "Correct";
                    break;
                case 5:
                    QuestionText.text = "What type of carbohydrates usually digest faster?";
                    TextA.text = "complex";
                    TextB.text = "double";
                    TextC.text = "simple";
                    TextD.text = "basic";
                    GameObject.Find("ButtonC").tag = "Correct";
                    break;
                case 6:
                    QuestionText.text = "What are the two types of carbohydrates?";
                    TextA.text = "good and bad";
                    TextB.text = "single and half";
                    TextC.text = "double and single";
                    TextD.text = "complex and simple";
                    GameObject.Find("ButtonD").tag = "Correct";
                    break;
                case 7:
                    QuestionText.text = "Which type of carbohydrates is better for you?";
                    TextA.text = "complex";
                    TextB.text = "double";
                    TextC.text = "simple";
                    TextD.text = "basic";
                    GameObject.Find("ButtonA").tag = "Correct";
                    break;
                case 8:
                    QuestionText.text = "Brown rice is an example of what type of carbohydrate?";
                    TextA.text = "complex";
                    TextB.text = "double";
                    TextC.text = "simple";
                    TextD.text = "A and C";
                    GameObject.Find("ButtonA").tag = "Correct";
                    break;
            }
        }

        
    }

    public void Answer(GameObject button)
    {
        if (qCount < 3)
        {
            if (button.tag == "Correct")
            {

                PwrUpScore.text = (System.Int32.Parse(PwrUpScore.text) + score).ToString();
                qCount++;
                if (qCount != 3)
                {
                    ResultText.text = "Good Job! " + (3 - qCount) + " more questions to go!";
                    score = 2;
                    button.tag = "Incorrect";
                    Quiz();
                }
                else
                {
                    ResultText.fontSize = 40;
                    powerups = System.Int32.Parse(PwrUpScore.text);
                    ResultText.text = "Awesome! Now we have all the energy we need for my track meet! Come on lets go play!";
                    PlayGameButton.SetActive(true);
                }
            }
            
            
            else
            {
                if (score > 0)
                {
                    score--;
                }
                ResultText.text = "Whoops, wrong answer. Try again!";
                Quiz();
            }
        }
        
    }

    public void miniGame()
    {
        Countdown.gameObject.SetActive(false);
        trackObjects.SetActive(true);
        
        //trackCarb.GetComponent<Rigidbody2D>().isKinematic = true;
        //rigid = trackCarb.transform.GetComponent<Rigidbody2D>();
        //GameObject.FindGameObjectWithTag("Main Camera").GetComponent<S>
        GameObject.Find("QuizGame").SetActive(false);
        Instructions.SetActive(true);
        //turn cartoon off
        GameObject.Find("CarbCartoon").SetActive(false);
        PlayGameButton.SetActive(false);
        //turn quizpanel transparency down all the way
        Image image = QuizPanel.GetComponent<Image>();
        Color c = image.color;
        c.a = 0;
        image.color = c;


        //Panel with instructions shows up
        Instructions.SetActive(true);
    }

    public void startMiniGame()
    {
        // turn off panel
        Instructions.SetActive(false);

        //start countdown
        Countdown.gameObject.SetActive(true);
        Countdown.text = "3";
        //System.Threading.Thread.Sleep(1000);
        Countdown.text = "2";
        //System.Threading.Thread.Sleep(1000);
        Countdown.text = "1";
        //System.Threading.Thread.Sleep(1000);
        Countdown.text = "GO!";
        //System.Threading.Thread.Sleep(1000);
        Countdown.gameObject.SetActive(false);

        //add collider to white line so that gameobjects cant go past it
        //can move the carb using keys
        move = true;
        

    }



    public void Update()
    {
        
        
        if (carbCarl.IsTouching(startLine))
        {
            touching = true;
            Debug.Log("Touching the Line");
        }
        if (carbCarl.IsTouching(Finish.GetComponent<Collider2D>()))
            {
            resultsPanel.SetActive(true);
            move = false;
            output.text = "YOU WIN!";
            Des.text = "The complex carbs really gave us an extra boost at this race!";
        }
        /*
        else if (carbCarl.IsTouching(topLine))
        {
            touchingTop = true;
            Debug.Log("Touching Top");
        }
        else if (carbCarl.IsTouching(bottomLine))
        {
            touchingBottom = true;
            Debug.Log("Touching Bottom");
        }
        else
        {
            touching = false;
            touchingTop = false;
            touchingBottom = false;
        }
        */
        
        if (move)
        {
            
            if (!touching)
            {
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    //Debug.Log("Move left");
                    Debug.Log("Move left");
                    Vector3 position = trackCarb.transform.position;
                    position.x -= speed;
                    trackCarb.transform.position = position;


                    Vector3 positionTrack = track.transform.position;
                    positionTrack.x += (float)2 * speed;
                    track.transform.position = positionTrack;
                    
                }
            }

            if (!carbCarl.IsTouching(Hurdle1) && !carbCarl.IsTouching(Hurdle2) && !carbCarl.IsTouching(Hurdle3))
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {

                    Vector3 position = trackCarb.transform.position;
                    position.x += speed;
                    trackCarb.transform.position = position;


                    Vector3 positionTrack = track.transform.position;
                    positionTrack.x -= (float)2 * speed;
                    track.transform.position = positionTrack;

                }
            }
            

            if (isGrounded() && Input.GetKey(KeyCode.UpArrow))
            {

                float jumpVelocity = 200f;
                rigid.velocity = Vector2.up * jumpVelocity;
            }
            

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (powerups > 0)
                {
                   
                    speed += 0.5f;
                    powerups--;
                    boostTimer += Time.deltaTime;
                    if (boostTimer >= 1)
                    {
                        speed--;
                        boostTimer = 0;
                    }
                    PwrUpScore.text = (powerups).ToString();

                }
            }
        }
    }

    private bool isGrounded()
    {
        RaycastHit2D raycast = Physics2D.BoxCast(carbCarl.bounds.center, carbCarl.bounds.size, 0f, Vector2.down, .1f, PlatformLayerMask);
        Debug.Log(raycast.collider);
        return raycast.collider != null;

    }
}


        
            
    



