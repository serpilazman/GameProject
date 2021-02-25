using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
   public class UserValidationManager : IUserValidationService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }

        public void Save(Gamer gamer)
        {
            throw new NotImplementedException();
        }
        
    }
}
