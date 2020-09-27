using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CanvasUIFunctions : MonoBehaviour
{
    Scene currentScene;
    [Header("Title Scene Properties", order = 0)]
    [Space(2f)]
    [Header("Intro Scene Properties", order = 1)]
    public TMP_Text introText;
    public GameObject introImage;
    public GameObject backButton;
    public GameObject nextButton;
    //[Header("Tutorial Scene Properties", order = 2)]
    //[Space(2f)]
    //[Header("Level01 Scene Properties", order = 3)]
    int introSequence;

    private void Awake()
    {
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
            case "03Level01Scene":
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

    public void IntroSequenceNext()
    {
        introSequence++;
        switch (introSequence)
        {
            case 0:
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
                    + "Students\n\n"
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
                    + "    •	Plays recreational sports but isn’t very dedicated to it\n"
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
                introText.text = "PROBLEM SCENARIO\n\n";
                break;
            case 9:
                introText.text = "ACTIVITY SCENARIO\n\n";
                break;
            case 10:
                introText.text = "ACTIVITY SCENARIO CONTINUTED\n\n";
                nextButton.SetActive(true);
                break;
            case 11:
                introText.text = "PROBLEM STATEMENT\n\n";
                nextButton.SetActive(false);
                break;
        }
    }

    public void IntroSequenceBack()
    {
        introSequence -= 2;
        IntroSequenceNext();
    }


}
