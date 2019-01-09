namespace BoulderDash
{
    public interface IGameObject
    {
        Tile CurrentTile { get; set; }
        char GetSymbol();
    }
}