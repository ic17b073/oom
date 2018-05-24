using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Beruf : IBeruf
    {
        private string bezeichnung;
        private bool ausgeschrieben;

        public Beruf(string bezeichnung, UInt32 jahresGehalt)
        {
            if (bezeichnung == null) { throw new ArgumentNullException("parameter is null."); }

            SetBezeichnung(bezeichnung);
            JahresGehalt = jahresGehalt;
            ausgeschrieben = false;
        }

        #region properties

        public string Bezeichnung
        {

            get { return this.bezeichnung; }
        }

        public bool Ausgeschrieben
        {

            get { return this.ausgeschrieben; }
        }

        public UInt32 JahresGehalt { get; set; }

        #endregion

        #region methods

        private void SetBezeichnung(string bezeichnung)
        {

            if (bezeichnung == null || bezeichnung.Length < 3)
                throw new Exception("Invalid ArgumentException!");

            this.bezeichnung = bezeichnung;
        }

        public void Ausschreiben(bool ausgeschrieben) { this.ausgeschrieben = ausgeschrieben; }

        #endregion
    }
}
