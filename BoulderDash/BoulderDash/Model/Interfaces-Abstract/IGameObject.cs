using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    public interface IGameObject
    {
        Tile CurrentTile { get; set; }
        char GetSymbol();
        ConsoleColor GetColor();
        bool Trigger(Direction dir);
        void Move(Direction dir);
        IGameObject Fall();
    }
}