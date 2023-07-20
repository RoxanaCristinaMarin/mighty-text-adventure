using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes;

public class KitchenScene : Scene
{
	private string KitchenArt = @"

 /|    |__I__I__I__I__I__I__I__I__I_|       _-       %       %         |\
  | _- |_I__I__I__I__I__I__I__I__I__|-_              %       %     _-  | 
  |    |__I__I__I__I__I__I__I__I__I_|                %       %         |
  |  - |_I__I__I__I__I__I__I__I__I__|               ,j,      %w ,      |
  | -  |__I__I__I__I__I__I__I__I__I_|  -_ -        / ) \    /%mMmMm.   |
  |    |_I__I__I__I__I__I__I__I__I__|             //|  |   ;  `.,,'    |
  |-_- /                            \             w |  |   `.,;`       |
  |   /                              \    -_       / ( |    ||         |
  |  /                                \           //\_'/    (.\    -_  |
  | /__________________________________\          w  \/   -  ``'       |
  | |__________________________________|                               |
  |    |   _______________________   |     _-            -             |
  |_-  |  |                       |  |                        _-       |
  |    |  |                     _ |  |  T  T  T  T  T                  |
  | _-_|  |    __.'`'`'`''`;__ /  |  |  |  |  |  |  |        _-     -  |
  |    |  | _/U  `'.'.,.,.,'  U   |  |  | (_) |  |  |                  |
  |    |  |   |               |   |  | / \    @ [_]d b    _@_     |    |   
  |    |  |   |      `', `,   |   |  | |_|   ____         [ ]     |    |
  |_-  |  |   |   `') ( )'    |   |  | ______\__/_________[_]__   |    | 
  |    |  |   |____(,`)(,(____|   |  |/________________________\  |    |
  |    |  |  /|   `@@(@@)@)'  |\  |  | ||            _____   ||   |    |
  |    |  | //!\  @@)@@)@@@( /!\\ |  | ||   _--      \   /   ||  /|\   |
  |__lc|__|/_____________________\|__|_||____________/###\___||_|||||__|
  / -_  _ -      _ -   _-_    -  _ - _ -|| -_    _  - \___/_- || |||||-_ 

";

	private string FlashlightArt = @"

				        /\
				       /  \
				       \/\/
				        ~|
				       !~~-!
				       |` ,!
				       |'` |
				       |   |
				       |   |
				       |   |
				       |   |
				       |   |
				_______|___|_______
				\                 /
				 \_______________/

";
	
	public KitchenScene(Game game) : base(game)
	{
        
	}

	public override void Run()
	{
		string[] options = { "Open drawer", "Make a sandwich", "Go back to living room" };
		Menu menu = new Menu(KitchenArt, options);
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				Clear();
				if (MyGame.MyPlayer.hasFlashlight)
				{
					WriteLine(@"
					
					The drawer is empty!

					");	
				}
				else
				{
					MyGame.MyPlayer.hasFlashlight = true;
					WriteLine(FlashlightArt);
					WriteLine(@"

					You found a candle and some matches. You picked them up. Maybe you need them later.

					");
				}
				WriteLine(@"
					
					Press any key to continue...
		
				");
				ReadKey(true);
				MyGame.MyKitchenScene.Run();
				break;
			case 1:
				MyGame.MyDeathScene.Run();
				break;
			case 2:
				MyGame.MyLivingRoomScene.Run();
				break;
		}
	}
}