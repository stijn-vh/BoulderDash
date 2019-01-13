using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    public interface IGameObject
    {
        Tile CurrentTile { get; set; }
        bool Sticks { get; }
        char GetSymbol();
        ConsoleColor GetColor();
        bool Trigger(Direction dir);
        IGameObject Fall();
        void Destroy();
        void Explode();
    }
}