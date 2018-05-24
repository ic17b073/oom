using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task4
{
    [TestFixture]
    public class Tests
    {
        private Beruf beruf;
        private Beruf beruf2;
        private Beruf[] berufe;

        public Tests()
        {
            beruf = new Beruf("Mechaniker", 20000);
            beruf2 = beruf;

            berufe = new Beruf[2]{ beruf, beruf2 };
        }


        [Test]
        public void Test_Konstruktor_Parameter1()
        {
            Assert.IsTrue(beruf.Bezeichnung == "Mechaniker");
        }

        [Test]
        public void Test_Konstruktor_Parameter2()
        {

            Assert.IsTrue(beruf.JahresGehalt == 20000);
        }

        [Test]
        public void Test_Konstruktor_ArgumentNullException()
        {

            Beruf _beruf;

            try
            {
                _beruf = new Beruf(null, 10000);

                Assert.IsTrue(false);
            }

            catch (ArgumentNullException ex)
            {
                Assert.IsTrue(true);
            }
        }

        [Test]
        public void Test_Field_Default_Value_ausgeschrieben()
        {

            Assert.IsFalse(beruf.Ausgeschrieben);
        }

        [Test]
        public void Test_Method_Ausschreiben()
        {

            beruf.Ausschreiben(true);


            Assert.IsTrue(beruf.Ausgeschrieben);
        }

        [Test]
        public void Test_Object_Equal()
        {
            Assert.AreEqual(beruf, beruf2);
        }

        [Test]
        public void Test_Array_Contains()
        {
            Assert.IsTrue(Array.Exists(berufe, element => beruf.Bezeichnung == "Mechaniker"));
        }

        [Test]
        public void Test_Change_Second_Instance()
        {
            beruf2.Ausschreiben(false);

            Assert.IsFalse(beruf.Ausgeschrieben);
        }

    }
}
