using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw002
{
    class User
    {
        public int id;
        public string name;

        public User(int Id1, string Name1)
        {
            ID = Id1;
            Name = Name1;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

}
