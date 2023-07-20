using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes.ParkScenes;

public class FightScene : Scene
{
	private int PlayerHP = 10;
	private int DogHP = 10;
	private int PlayerDamage;
	private int DogDamage;

	private Random _random = new Random();


	public FightScene(Game game) : base(game)
	{
	}

	public override void Run()
	{
		WriteLine(@"

			You have to battle the dog so you can gain access to the phone booth.
			Press any key to start the fight...

		");
		ReadKey(true);
		while (PlayerHP > 0 && DogHP > 0)
		{
			PlayerDamage = _random.Next(5);
			if (DogHP >= PlayerDamage)
			{
				DogHP -= PlayerDamage;
			}
			else if (DogHP < PlayerDamage)
			{
				DogHP = 0;
			}
			Clear();
			WriteLine(@$"


				Player HP: {PlayerHP}
				Dog HP: {DogHP}
				The dog got hit and received  {PlayerDamage} damage.
				Press any key to continue...


			");
			ReadKey(true);
			if (DogHP <= 0)
			{
				Clear();
				WriteLine(@"

					You defeated the dog and you can enter the phone booth safely.

					Press a key to continue...

				");
				ReadKey(true);
				MyGame.MyEnding.Run();
			}
			DogDamage  = _random.Next(5);
			PlayerHP -= DogDamage;
			Clear();
			WriteLine(@$"


				Player HP: {PlayerHP}
				Dog HP: {DogHP}
				You've got hit and received {DogDamage} damage.
				Press any key to hit...


			");
			ReadKey(true);

			if (PlayerHP <= 0)
			{
				MyGame.MyDeathScene.Run();
			}
		}

		
	}
}