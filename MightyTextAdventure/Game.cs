using MightyTextAdventure;
using MightyTextAdventure.Scenes;
using MightyTextAdventure.Scenes.ParkScenes;
using static System.Console;

namespace AdventureGameAttempt;

public class Game
{

    public Player MyPlayer;
    public TitleScene MyTitleScene;
    public CreditsScene MyCreditsScene;
    public RoomScene MyRoomScene;
    public DeathScene MyDeathScene;
    public LivingRoomScene MyLivingRoomScene;
    public KitchenScene MyKitchenScene;
    public BathroomScene MyBathroomScene;
    public YardScene MyYardScene;
    public ParkScene MyParkScene;
    public BenchScene MyBenchScene;
    public PhoneBoothScene MyPhoneBoothScene;
    public EndingScene MyEnding;
    public FightScene MyFightScene;

    public Game()
    {
        MyPlayer = new Player();
        MyTitleScene = new TitleScene(this);
        MyCreditsScene = new CreditsScene(this);
        MyRoomScene = new RoomScene(this);
        MyDeathScene = new DeathScene(this);
        MyLivingRoomScene = new LivingRoomScene(this);
        MyKitchenScene = new KitchenScene(this);
        MyBathroomScene = new BathroomScene(this);
        MyYardScene = new YardScene(this);
        MyParkScene = new ParkScene(this);
        MyBenchScene = new BenchScene(this);
        MyPhoneBoothScene = new PhoneBoothScene(this);
        MyEnding = new EndingScene(this);
        MyFightScene = new FightScene(this);

    }
    public void Start()
    {
        MyTitleScene.Run();
    }
}