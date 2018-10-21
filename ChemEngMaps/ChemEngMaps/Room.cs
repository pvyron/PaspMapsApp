using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ChemEngMaps
{
    public class Room
    {
        public int Floor { get; set; }

        public string Wing { get; set; }

        public int Code { get; set; }

        public FileImageSource Image { get; set; }

        public string GetRoom()
        {
            return Wing + "." + Floor + Code;
        }
    }
}
