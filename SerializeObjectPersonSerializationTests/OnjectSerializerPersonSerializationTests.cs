using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerializeObjectPerson;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeObjectPerson.Tests
{
    [TestClass()]
    public class OnjectSerializerPersonSerializationTests
    {
        [TestMethod]
        public void SerizlizeObjectJsonZeroPersonTest()
        {
            List<Person> pl = new List<Person>()
            {
            };

            OnjectSerializer s = new OnjectSerializer();

            string res = s.SerizlizeObjectJson(pl);
            Debug.WriteLine(res);

            Assert.AreEqual("{}", res);
        }

        [TestMethod]
        public void SerizlizeObjectJsonOnePersonTest()
        {
            List<Person> pl = new List<Person>()
            {
                new Person("fn", "ln", "454524", 10)
            };

            OnjectSerializer s = new OnjectSerializer();

            string res = s.SerizlizeObjectJson(pl);
            Debug.WriteLine(res);

            Assert.AreEqual("{{\"FName\":fn,\"LName\":ln,\"Phone\":454524,\"Age\":10}}", res);
        }

        [TestMethod]
        public void SerizlizeObjectJsonManuPersonTest()
        {
            List<Person> pl = new List<Person>()
            {
                new Person("fn", "ln", "454524", 10),
                new Person("asdas", "asdas", "4645524", 10),
                new Person("qwdqw", "sda", "45", 10)
            };

            OnjectSerializer s = new OnjectSerializer();

            string res = s.SerizlizeObjectJson(pl);
            Debug.WriteLine(res);

            Assert.AreEqual("{{\"FName\":fn,\"LName\":ln,\"Phone\":454524,\"Age\":10},{\"FName\":asdas,\"LName\":asdas,\"Phone\":4645524,\"Age\":10},{\"FName\":qwdqw,\"LName\":sda,\"Phone\":45,\"Age\":10}}", res);
        }
    }
}