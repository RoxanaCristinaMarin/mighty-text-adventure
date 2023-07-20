using System.ComponentModel;
using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes;

public class TitleScene : Scene
{
    public TitleScene(Game game) : base(game)
    {
    }
    public override void Run()
    {
        string prompt = @"
                 _    _      _                            _                                    ___      _                 _                  
                | |  | |    | |                          | |                                  / _ \    | |               | |                 
                | |  | | ___| | ___ ___  _ __ ___   ___  | |_ ___    _   _  ___  _   _ _ __  / /_\ \ __| |_   _____ _ __ | |_ _   _ _ __ ___ 
                | |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | | | |/ _ \| | | | '__| |  _  |/ _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
                \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_| | (_) | |_| | |    | | | | (_| |\ V /  __/ | | | |_| |_| | | |  __/
                 \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \__, |\___/ \__,_|_|    \_| |_/\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___|
                                                                      __/ |                                                                  
                                                                     |___/                                                                   
                (Use the Up or Down Arrow to browse through the menu and press Enter to select)



";
        WriteLine(@"

            Please enter a name for your character

         ");
        string name = ReadLine();
        Clear();
        WriteLine(@$"
            
            Hello {name}, let's start the adventure!

            Press any key to continue...

        ");
        ReadKey(true);
        
        string[] options = { "Play", "About", "Exit" };
        
        Menu mainMenu = new Menu(prompt, options);
        int selectedIndex = mainMenu.Run();

        switch (selectedIndex)
        {
            case 0:
                MyGame.MyRoomScene.Run();
                break;
            case 1:
                MyGame.MyCreditsScene.Run();
                break;
            case 2:
                ConsoleUtils.QuitTheGame();
                break;
        }
    }
}