using System.Linq;
using System.Reflection;

namespace ViewModels.Extensions
{
    public static class EnumExtension
    {
        public static System.Collections.Generic.IList<EnumSelectList> GetList<TEnum>()
        {
            var list =
                System.Enum.GetValues(typeof(TEnum)).Cast<TEnum>()
                .Select(c => new EnumSelectList
                {
                    Value = c.ToString(),
                    Text = GetDisplayName(c),
                }).ToList();

            return list;
        }

        public static string GetDisplayName<TEnum>(TEnum value)
        {
            if (value != null)
            {
                var member = 
                    value.GetType().GetMember(value.ToString())[0];

                var displayAttribute = 
                    member.GetCustomAttribute<System.ComponentModel.DataAnnotations.DisplayAttribute>();

                if (displayAttribute != null)
                {
                    return displayAttribute.GetName();
                }

                return value.ToString();
            }

            return null;
        }
    }
}
