using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace PoruTelApp
{
    public class MenuSingleton
    {
        private static Meniu instance = null;
        public static Meniu Meniu
        {
            get
            {
                if (instance == null)
                {
                    instance = new Meniu();
                }
                return instance;
            }
        }
    }
}
