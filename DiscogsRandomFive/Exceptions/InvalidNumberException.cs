using System;


namespace DiscogsRandomFive.Exceptions
{
    public class InvalidNumberException:Exception
    {
        private string _Message;
        public override string Message
        {
            get { return _Message; }
        }
        public InvalidNumberException() 
        {
            
            _Message = "Le nombre de disques doit être entre 1 et 5";


        }

      
    }
}
