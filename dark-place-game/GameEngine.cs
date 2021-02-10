using System;

namespace dark_place_game
{
    public interface IInputProvider
    {
        public string ReadLine();
    }

    public interface IOutputProvider
    {
        public void WriteLine(string textLine);
    }

    public interface IRandomProvider
    {
        public int GetRandomInt();
    }
    
    public class GameEngine
    {
        public IInputProvider Input {
            get;
            private set;
        }

        public IOutputProvider Output {
            get;
            private set;
        }

        public IRandomProvider Random {
            get;
            private set;
        }
        
        public GameEngine(IInputProvider inputProvider,IOutputProvider outputProvider, IRandomProvider randomProvider) {
            Input = inputProvider;
            Output = outputProvider;
            Random = randomProvider;
        }

        public void Update() {
            var input = Input.ReadLine();
        }

    }

}
