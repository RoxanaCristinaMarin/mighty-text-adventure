using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes;

public class RoomScene : Scene
{
    private string BedroomArt = @"
                    _      ()              ()      _
                   / \     ||______________||     / \
                  /___\    |                |    /___\
                    |      |      ~@@~      |      |
                   (_)     |_______  _______|     (_)
                ___/_\___  {_______}{_______}  ___/_\___
                 |__~__|   %%%%%%%%%%%%%%%%%%   |__~__|
              ___|_____|__%%%%%%%%%%%%%%%%%%%%__|_____|___
                 |     | %%%%%%%%%%%%%%%%%%%%%% |     |
                  `=====%%%%%%%%%%%%%%%%%%%%%%%%=====`
                 `=====%%%%%%%%%%%%%%%%%%%%%%%%%%=====`
                `=====%%%%%%%%%%%%%%%%%%%%%%%%%%%%=====`
               `=====/||||||||||||||||||||||||||||\=====`
              `======||||||||||||||||||||||||||||||======`
             `=======|||||||||||||||||||||||||||lc|=======`
            `==============================================`
           `================================================`
          `==================================================`
         `====================================================`

         You wake up all sweaty and feel confused. You can barely open your eyes. You hear a loud thunder. 
         You look towards the window as a lightning bolt hits the curtains. Your bedroom is on fire.
         You pick up your phone to call 911 but it has no battery.
         Your heart is racing.
         What do you do next? 

";
    
    public RoomScene(Game game) : base(game)
    {
        
    }

    public override void Run()
    {
       string[] options = { "Run to the living room", "Stay in bed" };
       Menu menu = new Menu(BedroomArt, options);
       int SelectedIndex = menu.Run();

       switch (SelectedIndex)
       {
        case 0:
         MyGame.MyLivingRoomScene.Run();
         break;
        case 1:
         MyGame.MyDeathScene.Run();
         break;
       }
        
    }
}