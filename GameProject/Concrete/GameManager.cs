using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        

        public void Save(Game game)
        {
            Console.WriteLine("Saved to DB:"+game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Updated on DB:" + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Deleted from DB:" + game.GameName);
        }
    }
}
