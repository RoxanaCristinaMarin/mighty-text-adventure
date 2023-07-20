using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes;

public class YardScene : Scene
{
	private string[] options;
	private Menu menu;
	private string YardArt = @"

			         ********
			        ****************
			      *******************
			      ********************
			       ********************
			          \\   //  ********
			           \\\//  *******
			             \\\////
			              |||//                       ,
			              |||||                    __/
			  ,,,,,,,,,,,//||||\,,,,,,,,,,,,,,,,,,o==o
			  ;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

			";
	
	public YardScene(Game game) : base(game)
	{
		string[] options = { "Stay there and cry", "Find a public phone to call 911" };
		menu = new Menu(YardArt, options);
	}

	public override void Run()
	{
		
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				Clear();
				WriteLine(@"

					You cannot move. You just stay there and cry and cry with no more hope at all!

				");
				ReadKey(true);
				MyGame.MyYardScene.Run();
				break;
			case 1:
				MyGame.MyParkScene.Run();
				break;
		}
	}
}