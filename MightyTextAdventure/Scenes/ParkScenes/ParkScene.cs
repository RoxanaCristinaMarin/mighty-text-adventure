using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes.ParkScenes;

public class ParkScene : Scene
{
	private string ParkArt = @"

	
			               ,@@@@@@@,
			       ,,,.   ,@@@@@@/@@,  .oo8888o.
			    ,&%%&%&&%,@@@@@/@@@@@@,8888\88/8o
			   ,%&\%&&%&&%,@@@\@@@/@@@88\88888/88'
			   %&&%&%&/%&&%@@\@@/ /@@@88888\88888'
			   %&&%/ %&%%&&@@\ V /@@' `88\8 `/88'
			   `&%\ ` /%&'    |.|        \ '|8'
			       |o|        | |         | |
			       |.|        | |         | |
			jgs \\/ ._\//_/__/  ,\_//__\\/.  \_//__/_

";
	
	public ParkScene(Game game) : base(game)
	{
		
	}

	public override void Run()
	{
		string[] options = { "Take a seat on the bench", "Go to the phone booth" };
		Menu menu = new Menu(ParkArt, options);
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				MyGame.MyBenchScene.Run();
				break;
			case 1:
				MyGame.MyPhoneBoothScene.Run();
				break;
		}
	}
}