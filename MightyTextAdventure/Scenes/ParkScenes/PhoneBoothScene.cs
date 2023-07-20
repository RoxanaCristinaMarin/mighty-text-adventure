using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes.ParkScenes;

public class PhoneBoothScene : Scene
{
	private string PhoneArt = @"
					     __________________
					    /                  \                
					    '------------------'                                     
					    | .--------------. |                                     
					    | |      ||      | |        
					    |[]      ||      | |         
					    | |======||======| |   
					    | |      ||      | |      
					    | |      ||      | |                
					    |[]======||======[ |                                     
					    | |======||======| |                                     
					    | |      ||      | |                                     
					    | |      ||      | |                                     
					    |[]======||======| |                                     
					    | |      ||      | |                                     
					    | '------''------' |                                     
					    |__________________| 

";

	private string DogArt = @"

						     |\_/|                  
						     | @ @   Woof! 
						     |   <>              _  
						     |  _/\------____ ((| |))
						     |               `--' |   
						 ____|_       ___|   |___.' 
						/_/_____/____/_______|

";
	public PhoneBoothScene(Game game) : base(game)
	{
		
	}

	public override void Run()
	{
		string[] options = { "Get into Phone Booth", "Go to the bench" };
		Menu menu = new Menu(PhoneArt, options);
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				Clear();
				if (MyGame.MyPlayer.hasBone)
				{
					WriteLine(DogArt + @"

						You encounter a vicious dog and you remember that you have a bone in your pocket.
						You get the bone out for the dog to see and then throw it.
						The dog takes the bait and runs pleased to catch the bone. 

						Press a key to continue...

					");
					ReadKey(true);
					MyGame.MyEnding.Run();
				}
				else
				{
					MyGame.MyFightScene.Run();
				}
				break;
			case 1:
				MyGame.MyBenchScene.Run();
				break;
		}
	}
}