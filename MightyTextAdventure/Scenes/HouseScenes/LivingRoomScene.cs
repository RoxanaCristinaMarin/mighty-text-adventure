using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes;

public class LivingRoomScene : Scene
{
	private string LivinRoomArt = @"

			                                                          ||__||
			                                                          |__|||
			                  ..______________________________________||__||___________
			                .  |                 [Home sweet Home]    |__|||    .____.
			               .   |                     .________.       ||__||    |/\ *|
			             .     |     wwwwwwwww       |      .'|       |__|||    |____|
			            .      |     |)__|__(| (Moo) |    .'  |     __||__||__.
			          .    /|  |     |\  |  /|     \\|(__)|   |    /__|__||/_/|
			         .    /%|  |     '======='       |(oo)|   |    |_._____._||
			       .     |@/   |                     | \/ |o  |    |_|/^^^\|_||
			      .      |/    |_____________________|____|  ,|____|_|*****|_|/________
			    .             .                           | ,      ____________      
			   .    ._.     .     __________.             |.     =/ o      o  /=
			 .     / /|    .     /_/-----/_/|   __              =/    X  .   /=
			|     / /||  .       ( ( ' ' ( (| /'--'\           =/___________/=     
			|    /_/|/| .        (_( ' ' (_(|/.    .\
			|    |||/||          / /=====/ /|  '||'
			|    ||/|/          /_//____/_/ |   ||						         
			|    |||/          (o|:.....|o) |   ||				
			|    ||/           |_|:_____|_|/'  _||_             
			|   .               '        '    /____\						   
			|  .                                                      
			|_________________________________________________________________.



";
	
	public LivingRoomScene(Game game) : base(game)
	{
        
	}

	public override void Run()
	{
        
		string[] options = { "Open the Door", "Go to the Kitchen", "Go to the Bathroom" };
		Menu menu = new Menu(LivinRoomArt, options);
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				if (MyGame.MyPlayer.hasKey)
				{
					Clear();
					WriteLine(@"

						You made it! You got out of the burning house! 
						Now you have to find a phone to call 911 and save what is left of your house!	

						Press any key to continue...	

					");
					ReadKey(true);
					MyGame.MyYardScene.Run();
				}
				WriteLine(@"

					The door is locked! Find the key to unlock it!

					Press any key to continue...

				");
				ReadKey(true);
				MyGame.MyLivingRoomScene.Run();
				break;
			case 1:
				MyGame.MyKitchenScene.Run();
				break;
			case 2:
				Clear();
				if (MyGame.MyPlayer.hasFlashlight)
				{
					MyGame.MyBathroomScene.Run();
				}
				else
				{
					WriteLine(@"

						The room is dark and you cannot see anything.

						Press any key to continue... 

					");
					ReadKey(true);
					MyGame.MyLivingRoomScene.Run();
				}
				
				break;
		}
	}
}