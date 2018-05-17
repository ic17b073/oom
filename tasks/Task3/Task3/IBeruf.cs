using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IBeruf
    {
        /// <summary>
        /// Gets the name
        /// </summary>
        string Bezeichnung
        {
            get;
        }

        /// <summary>
        /// Gets or sets the payment
        /// </summary>
        UInt32 JahresGehalt { get; set; }
    }
}
