using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes.ParkScenes;

public class BenchScene : Scene
{
	private string BenchArt = @"

				       ______________        _____________
				     !/ ........... (_     _) ........... \!
				     |.'           '. (_!_) .'           '.|
				    .'               '.....'               '.
				    :                                       :
				    :                                       :
				    :                                       :
				  .' '.....................................' '.
				.'  .'                                     '.  '.
				@'.'                                         '.'@
				 \'...........................................'/
				  |___________________________________________|
				  (   /|                                 |\   )
				   ) |_|                                 lc| (
				   | |                                     | |
				   | |                                     | |
				  (__|                                     |__)

";

	private string BoneArt = @"

					
					    (   `-._________.-'   )
					     >=     _______     =<
					    (   ,-'`       `'-,   )
					     `-'               `-'

";

	private string DucksArt = @"

				  _      _      _
               __(.)< __(.)> __(.)=
               \___)  \___)  \___) 

";
	public BenchScene(Game game) : base(game)
	{
		
	}

	public override void Run()
	{
		string[] options = { "Pick up the bone", "Look at the ducks swimming in the fountain", "Go to the Phone Booth" };
		Menu menu = new Menu(BenchArt, options);
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				Clear();
				
				if (MyGame.MyPlayer.hasBone)
				{
					WriteLine(@"

						You already took the bone!

					");
				}
				else
				{
					WriteLine(BoneArt + @"

						You pick up the bone. You start chewing on it but it's too tough for your sensitive teeth.
						You choose to put it in your pocket. 

						Why?

						Why the heck not!

						Press any key to continue...

					");
					MyGame.MyPlayer.hasBone = true;
				}
				ReadKey(true);
				MyGame.MyBenchScene.Run();
				break;
			case 1:
				Clear();
				WriteLine(DucksArt + @"
	
					The duck are swimming peacefully. You cannot take your eyes off them even if you have more urgent things to do!
					You should really set your priorities straight! This doesn't seem like the time to be watching ducks, you moron!

					Press any key to continue... 
	
				");
				ReadKey(true);
				MyGame.MyBenchScene.Run();
				break;
			case 2:
				MyGame.MyPhoneBoothScene.Run();
				break;
		}
	}
}