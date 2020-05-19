using System;
using static XamarinEssentials.Model.ButtonModel;

namespace XamarinEssentials.Model
{
    public class ButtonModel
    {
        public string Name { get; set; }
        public enum Category {
            Information,
            Measuring,
            Services,
            Functions
        };

        
    }

    public static class ConvertCommandToString
    {
        public static String convertToString(this Enum eff)
        {
            return Enum.GetName(eff.GetType(), eff);
        }

        public static Category convertToEnum<EnumType>(this String enumValue)
        {
            return (Category)Enum.Parse(typeof(Category), enumValue);
        }
    }
}
