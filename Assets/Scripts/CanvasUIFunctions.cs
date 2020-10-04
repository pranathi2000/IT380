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
                introText.text = "ACTIVITY SCENARIO CONTINUTED\n\n"
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


}
