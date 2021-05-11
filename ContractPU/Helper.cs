using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContractPU
{
    public class Helper
    {
        public void Conn()
        {
           
            var settings = ConfigurationManager.ConnectionStrings[0];
            var fi = typeof(ConfigurationElement).GetField(
                          "_bReadOnly",
                          BindingFlags.Instance | BindingFlags.NonPublic);
            fi.SetValue(settings, false);
            settings.ConnectionString = "Data Source=Something";
        }
        


    }
}
