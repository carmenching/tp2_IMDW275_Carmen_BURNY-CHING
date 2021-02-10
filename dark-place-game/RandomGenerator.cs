using System;

namespace dark_place_game
{
    class RandomGenerator : IRandomProvider
    {
        private Random random;

        public RandomGenerator() {
            random = new Random();
        }
        
        public int GetRandomInt() {
            return random.Next();
        }
    }


}
