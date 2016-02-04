using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Class2Dictionary
{
    public static class C2D
    {
				public static Dictionary<string, string> ConvertC2D(this IC2D obj) {
					var dictionary = new Dictionary<string, string>();
					Type type = obj.GetType();
					PropertyInfo[] properties = type.GetProperties();

					foreach (PropertyInfo property in properties)
					{
						var fieldName = property.Name;
						var fieldValue = property.GetValue(obj, null);
						dictionary.Add(fieldName, fieldValue.ToString());
					}
					return dictionary;
				}
    }
}
