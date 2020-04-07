using System;
using System.Collections.Generic;
using System.Text;
using XamarinEssentials.Model;

namespace XamarinEssentials.Data
{
    public class APINameList
    {
        public static void List()
        {
            var appNames = new List<API>
            { new API  {Name = "Connectivity"},
            new API {Name = "Flashlight"},
            new API {Name = "Colour Converter"},
            new API {Name = "Theme Detector"}
            };
        }

       
    }
}
