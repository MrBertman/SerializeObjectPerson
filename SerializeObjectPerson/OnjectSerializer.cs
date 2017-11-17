using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SerializeObjectPerson
{
    public class OnjectSerializer
    {
        public string SerizlizeObjectJson(object persons)
        {
            string res = "{";

            Type t = typeof(Person);  //persons.GetType().GetProperties("Item").GetType();

            var enumerable = persons as System.Collections.IEnumerable;

            foreach (var item in enumerable)
            {
                res += "{";

                var fields = item.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
                foreach (var field in fields)
                {
                    var name = (field as FieldInfo).Name;
                    var value = (field as FieldInfo).GetValue(item);
                    res += "\"" + name + "\":" + value + ",";
                }

                res = res.Remove(res.LastIndexOf(','), 1);

                res += "},";
            }
            res += "}";       

            if(res.LastIndexOf(',') > 0)
                res = res.Remove(res.LastIndexOf(','), 1);

            return res;
        }
        /*
        private string SerializeField(object Field)
        {
            string res = null;

            //if(Field.GetType().IsPrimitive)
            //{
                var name = (Field as FieldInfo).Name; // .GetType().Name;
            var value = (Field as FieldInfo).GetValue(name);
            //PropertyInfo pi = Field.GetType().GetProperty("name");
            //String value = (String)(pi.GetValue(Field, null));

            //var value = (Field as FieldInfo).GetValue(Field.GetType());
            res += "\"" + name + ":" + value; 
            //}
            //else
            //{
            //    res = "\"" + (Field as PropertyInfo).Name + ":{";
            //    var fields = Field.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance);
            //    foreach (var field in fields)
            //    {
            //        res += SerializeField(field);
            //    }
            //    res += "}";
            //}
            return res;
        }
        */
    }
}
