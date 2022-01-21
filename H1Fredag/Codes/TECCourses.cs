using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Fredag.Codes
{
    internal class TECCources
    {
        public string[]? Cources { get; set; }
        public string[,]? AllCources { get; set; }

        public string[][] AllCourcesJagged { get; set; }

        #region Constructor

        public TECCources(string[] cources)
        {
            Cources = cources;
        }

        public TECCources(string[,] cources2D)
        {
            AllCources = cources2D;
        }

        public TECCources(string[][] cources2D)
        {
            AllCourcesJagged = cources2D;
        }

        #endregion
    }
}