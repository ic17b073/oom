using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Techniker : IBeruf
    {
        private string beruf;
        private string name;

        public Techniker(string beruf, string name)
        {

            Random rnd = new Random();

            this.name = name;
            this.beruf = beruf;
            this.JahresGehalt = (UInt32)rnd.Next(5000, 100000);
        }

        #region Properties
        public string Bezeichnung { get { return beruf; } }

        public UInt32 JahresGehalt { get; set; }

        public string Name { get { return name; } }

        #endregion

        #region methods

        public void SetName(string name)
        {

            if (name == null) { throw new ArgumentNullException("name is null"); }

            this.name = name;
        }

        #endregion



    }
}
