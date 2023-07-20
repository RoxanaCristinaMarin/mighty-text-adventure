namespace AdventureGameAttempt.Scenes;

public abstract class Scene
{
    protected Game MyGame;
    
    public Scene(Game game)
    {
        MyGame = game;
    }

    public abstract void Run();

}