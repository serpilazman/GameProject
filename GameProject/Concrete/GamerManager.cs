using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Adapters;
using MernisServiceReference;


namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
       public IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void Save(Gamer gamer)
        {


            if (_userValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Saved to DB:" + gamer.FirstName);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated this gamer:" + gamer.FirstName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted this gamer:" + gamer.FirstName);
        }






        //private MernisServiceAdapter mernisServiceAdapter;

        //public GamerManager(MernisServiceAdapter mernisServiceAdapter)
        //{
        //    this.mernisServiceAdapter = mernisServiceAdapter;
        //}
        //private IUserValidationService _userValidationService;

        //public GamerManager(IUserValidationService userValidationService)
        //{
        //    _userValidationService = userValidationService;
        //}

        //public GamerManager(MernisServiceAdapter mernisServiceAdapter) : base(mernisServiceAdapter)
        //{
        //}

        //public override void Save(Gamer gamer)
        //{
        //    if (_userValidationService.CheckIfRealPerson(gamer))
        //    {
        //        base.Save(gamer);
        //    }

        //    else
        //    {
        //        throw new Exception("Not a valid person");
        //    }

        //}

        //public bool CheckIfRealPerson(Gamer gamer)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Save()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Gamer gamer)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Gamer gamer)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
