using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface ICanCRUD
    {
        void create();
        string read();
        void update(string input);
        void delete();
    }
}
