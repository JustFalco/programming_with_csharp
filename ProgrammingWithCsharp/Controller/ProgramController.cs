using System;
namespace ProgrammingWithCsharp
{
    public class ProgramController
    {
        private User loggedinUser;

        public User LoggedinUser {
            get {
                return loggedinUser;
            }
            set {
                loggedinUser = value;
            }
        }


        public ProgramController()
        {
            new HomeView();


        }
    }
}

