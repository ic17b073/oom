using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Beruf
    {
        private string bezeichnung;
        private bool ausgeschrieben;

        public Beruf(string bezeichnung, UInt32 jahresGehalt) {

            this.Bezeichnung = bezeichnung;
            this.JahresGehalt = jahresGehalt;
            this.Ausgeschrieben = false;
        }

        public string Bezeichnung {

            get { return this.bezeichnung; }

            private set {

                if (value == null || value.Length < 3)
                    throw new Exception("Invalid ArgumentException!");

                this.bezeichnung = value; }
        }

        public UInt32 JahresGehalt { get; set; }

        public bool Ausgeschrieben {

            get { return this.ausgeschrieben; }

            private set { this.ausgeschrieben = value; }

        } 

        public void Ausschreiben(bool ausgeschrieben) { this.Ausgeschrieben = ausgeschrieben;   } 
    }
}
