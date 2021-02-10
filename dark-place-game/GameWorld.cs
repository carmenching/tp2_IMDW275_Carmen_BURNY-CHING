using System;

namespace dark_place_game
{
    class GameWorld
    {
        Hero hero;
        
        public GameWorld() {

        }

        public void Initialize(string playerName) {
            hero = new Hero(playerName);
        }
    }

}
