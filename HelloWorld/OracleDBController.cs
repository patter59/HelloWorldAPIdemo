using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorld
{
    class OracleDBController : ICanCRUD
    {
        public void create()
        {

        }
        public string read()
        {
            string connString = ConfigurationManager.AppSettings["constr"];
            string dfltMSG = ConfigurationManager.AppSettings["dfltmsg"];
            string slctString = "SELECT message FROM msgTable";
            string message = null;
            message = oracleSelect(slctString, connString);

            if(message != null)
            {
                return message;
            }
            else
            {
                return dfltMSG;
            }
            
        }
        public void update(string input)
        {

        }
        public void delete()
        {

        }


        private string oracleSelect(string selectString, string connectionString)
        {
            //database stuff here
            return null;
        }
    }
}
