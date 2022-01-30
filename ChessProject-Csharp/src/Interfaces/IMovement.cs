using System;

namespace SolarWinds.MSP.Chess
{
   public interface IMovement
   {
        public void Move(int newX, int newY);
        public void Capture(int newX, int newY, bool isOccupied);
   } 
}