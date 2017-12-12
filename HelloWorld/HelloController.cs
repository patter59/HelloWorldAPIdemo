using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloController : HelloWorldAPI
    {
        IPrintable msg1 = new HelloMsg();
        ICanCRUD data1 = new OracleDBController();

        string helloMessage = null;
        public void setMessage()
        {
            data1.update(helloMessage);
        }
        public void searchMessage()
        {
            helloMessage = data1.read();
        }
        public void printMessage()
        {
            msg1.print(helloMessage);
        }

    }
}
