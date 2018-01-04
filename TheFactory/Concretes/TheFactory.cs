using System;
using System.Collections.Generic;
using System.Text;
using TheFactory.Abstracts;
using TheFactory.Concretes;

namespace TheFactory.Concretes
{
    public class TheFactory : Factory
    {
        public SCPDocument PrintSCP(string title, string scproceedures, string description)
        {
            SCPDocument Scip = new SCPDocument(title,scproceedures,description);
        }

        public TheFactory(string _user)
        {
            user = _user;
        }
    }
}
