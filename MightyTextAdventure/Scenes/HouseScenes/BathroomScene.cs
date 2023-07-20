using AdventureGameAttempt;
using AdventureGameAttempt.Scenes;
using static System.Console;

namespace MightyTextAdventure.Scenes;

public class BathroomScene : Scene
{
	private string BathroomArt = @"

					|% % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % %| 
					| % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % % | 
					|% % % % % %_____________________________ % % % % % % % % % % % % % % % % % % % | 
					| % % % % %|  _________________________  | % % % % % % % % % % % % % % % % % % %| 
					|% % _ % % |O|                         |O|% % % % % % % % % % _ % % % % % % % % | 
					| % /_\ % %| | //                      | | % % % % % % % % % /_\ % % % % % % % %| 
					|%  =|=  % |O|                         |O|% % % % % % % % %  =|=  % % % % % % % | 
					| % % % % %| |    //                   | | % % % % % % % % % % % % % % % % % % %| 
					|% % % % % |O|                         |O|% % % % % % % % % % % % % % % % % % % | 
					|==========| |                         | |======================================| 
					| SHOWERS  |O|                         |O|                                      | 
					| <=====   | | //                      | |              ________________        | 
					|          |O|_________________________|O|             |________________|       | 
					|          |_____________________________|               |            |    _    | 
					|           ______________/;____________                 |~           |  =)_)=  | 
					|         /`        .--T--|--T--.       `\       ____    |            |   (_(   | 
					|        /_________'------'------'________\     /PUSH\   |__%______%__|   )_)   | 
					|         |  _____   ____   ____   _____ |     /______\   .`        `.          | 
					|         | |__~__| |    | |    | |__~__||     |      |   :          :          | 
					|         |         |    | |    |        |     |      |    '.      .'           | 
					lc________|         |   {| |}   |        |_____|      |______\`'-'`/____________| 
					          |         |    | |    |        |     |______|       |   | 
					          |_________|____|_|____|________|                    |___| 

";
	
	private string KeyArt = @"

			                                    ▓▓▓▓              
			                                  ▓▓    ▓▓▓▓  ████    
			                                ▓▓    ░░    ▓▓██▓▓██  
			                                ▓▓  ░░▓▓▓▓    ▓▓████  
			                              ▓▓  ░░▓▓    ▓▓    ▓▓    
			                            ▓▓░░  ▓▓    ░░░░▓▓    ▓▓  
			                            ▓▓  ▓▓    ░░░░░░      ▓▓  
			                            ▓▓    ▓▓░░░░░░    ▓▓░░  ▓▓
			                            ▓▓░░    ▓▓░░    ▓▓░░    ▓▓
			                              ▓▓      ▓▓  ▓▓░░    ▓▓  
			                            ██▓▓▓▓      ▓▓    ▓▓▓▓    
			                          ██▓▓░░▓▓▓▓░░    ░░▓▓        
			                        ██░░░░░░██  ▓▓▓▓▓▓▓▓          
			        ████          ██░░░░  ██                      
			      ██    ████    ██░░░░  ██                        
			      ████    ░░████░░░░  ██                          
			  ████░░████░░░░██░░░░  ██                            
			██  ████░░    ██░░░░  ██                              
			██░░  ██    ██░░░░  ██                                
			████  ░░░░██░░░░  ██                                  
			  ████░░██░░░░  ██                                    
			    ████░░░░  ██                                      
			      ██░░  ██                                        
			        ████   


";
	
	public BathroomScene(Game game) : base(game)
	{
        
	}

	public override void Run()
	{
		string[] options = { "Take shelter in the bathtub", "Poop", "Take your schizophrenia meds", "Go back to the Living Room" };
		Menu menu = new Menu(BathroomArt, options);
		int SelectedIndex = menu.Run();

		switch (SelectedIndex)
		{
			case 0:
				MyGame.MyDeathScene.Run();
				break;
			case 1:
				Clear();
				WriteLine(@" 

					This is not the time to take a dump!!! 
				
					Press any key to continue...
		
				");
				ReadKey(true);
				MyGame.MyBathroomScene.Run();
				break;
			case 2:
				Clear();
				if (MyGame.MyPlayer.hasKey)
				{
					WriteLine(@" 
						
						You already took your meds and found the key!
						Press any key to continue...

					");
					ReadKey(true);
					MyGame.MyBathroomScene.Run();
				}
				else
				{
					MyGame.MyPlayer.hasKey = true;
					WriteLine(KeyArt);
					WriteLine(@" 

						You reach for the meds and find the key right next to the bottle.

						You put the key in your pocket and take the meds anyway just to be sure.

					");
					ReadKey(true);
					MyGame.MyBathroomScene.Run();
				}
				break;
			case 3:
				MyGame.MyLivingRoomScene.Run();
				break;
		}
	}
}