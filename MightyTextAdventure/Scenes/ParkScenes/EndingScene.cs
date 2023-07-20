using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes.ParkScenes;

public class EndingScene : Scene
{
	private string EndingArt = @"

					__   __                          _         _  
					\ \ / /                         (_)       | | 
					 \ V /   ___   _   _  __      __ _  _ __  | | 
					  \ /   / _ \ | | | | \ \ /\ / /| || '_ \ | | 
					  | |  | (_) || |_| |  \ V  V / | || | | ||_| 
					  \_/   \___/  \__,_|   \_/\_/  |_||_| |_|(_) 

				You manage to call 911. The fire fighters are on their way.
				They manage to save most of the house.

";
	public EndingScene(Game game) : base(game)
	{
	}

	public override void Run()
	{
		string[] options = { "Play again", "Exit" };
		Menu menu = new Menu(EndingArt, options);
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				MyGame.MyTitleScene.Run();
				break;
			case 1:
				ConsoleUtils.QuitTheGame();
				break;
		}
	}
}