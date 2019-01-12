using BoulderDash.Model.Interfaces_Abstract;
using System;

namespace BoulderDash
{
    internal class HardenedMud : LooseObject
    {
        private int strength = 2;
        public override bool Sticks => true;
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkMagenta;
        }

        public override char GetSymbol()
        {
            return 'H';
        }

        public override bool CanFall()
        {
            int amountOfSticky = 0;

            if (CurrentTile.Up.DoesTileContentStick())
            {
                amountOfSticky++;
            }
            if (CurrentTile.Right.DoesTileContentStick())
            {
                amountOfSticky++;
            }
            if (CurrentTile.Left.DoesTileContentStick())
            {
                amountOfSticky++;
            }

            if (amountOfSticky >= 2)
            {
                return false;
            }
            else
            {
                if (CurrentTile.Down.TileContent == null || CurrentTile.Down.TileContent is Rockford || CurrentTile.Down.TileContent is FireFly) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override bool CanSlide()
        {
            return false;
        }

        public override bool Trigger(Direction dir)
        {
            if (strength == 0)
            {
                return true;
            }
            else
            {
                strength--;
                return false;
            }
        }
    }
}