using System;

namespace Reign_of_Grelok.state
{
    class Management
    {
        private bool hasSeeTown;
        private bool hasFinishedGame;
        public Management() {
            hasSeeTown = false;
            hasFinishedGame = false;
        }

        public void SeeTown() { this.hasSeeTown = true; }

        public void FinishGame() { this.hasFinishedGame = true; }
    }
}
