namespace MightyTextAdventure;

public class Player
{
    public bool hasFlashlight;
    public bool hasBone;

    public bool hasKey { get; set; }

    public Player()
    {
        hasFlashlight = false;
        hasKey = false;
        hasBone = false;
    }
}