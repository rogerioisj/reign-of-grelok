using System;

namespace Reign_of_Grelok.state
{
    class Management
    {
        private bool hasSawTown;
        private bool hasSawChapel;
        private bool hasKilledZombie;
        private bool hasUsedKey;
        private bool hasFinishedGame;
        public Management() {
            hasSawTown = false;
            hasSawChapel = false;
            hasKilledZombie = false;
            hasUsedKey = false;
            hasFinishedGame = false;
        }

        public void SeeTown() { this.hasSawTown = true; }

        public void SeeChapel() { this.hasSawChapel = true; }

        public void KillZombie() { this.hasKilledZombie = true; }

        public void UseKey() { this.hasUsedKey = true; }

        public void FinishGame() { this.hasFinishedGame = true; }

        public bool AlreadyCheckTown() { return this.hasSawTown; }

        public bool AlreadyCheckChapel() { return this.hasSawChapel; }

        public bool AlreadyKilledZombie() { return this.hasKilledZombie; }

        public bool AlreadyUsedKey() { return this.hasUsedKey; }


    }
}
