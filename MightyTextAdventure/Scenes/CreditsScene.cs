using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;

namespace MightyTextAdventure.Scenes;

public class CreditsScene : Scene
{
    public CreditsScene(Game game) : base(game)
    {
        
    }

    public override void Run()
    {
        string prompt = @"
              ___  _                 _   
             / _ \| |               | |  
            / /_\ \ |__   ___  _   _| |_ 
            |  _  | '_ \ / _ \| | | | __|
            | | | | |_) | (_) | |_| | |_ 
            \_| |_/_.__/ \___/ \__,_|\__|  

            This game was created by AdventureTime.Inc with the help of a lot of tutorials frm Mike Hadley.
            It uses assets from https://patorjk.com/software/taag.    
            It uses assets from https://patorjk.com/software/taag.  
            This is just a demo... full game coming to the console near you soon!   

            Would you like to play again? 
             
        ";
        string[] options = { "Yes", "No" };
        Menu menu = new Menu(prompt, options);
        int SelectedIndex = menu.Run();

        switch (SelectedIndex)
        {
            case 0:
                MyGame.Start();
                break;
            case 1:
                ConsoleUtils.QuitTheGame();
                break;
        }
    }
}