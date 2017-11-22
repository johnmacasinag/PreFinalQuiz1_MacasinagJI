using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace PreFinalQuiz1_MacasinagJI.App_Code
{
    public class Tulong
    {
        public static string GetCon()
        {
            return ConfigurationManager.ConnectionStrings["HomeCon"].ConnectionString;
        }
    }
}