using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexa.NET.Assimp
{
    public static unsafe partial class Assimp
    {
        static Assimp()
        {
            InitApi();
        }

        public static string GetLibraryName()
        {
            return "assimp-vc143-mtd";
        }
    }
}