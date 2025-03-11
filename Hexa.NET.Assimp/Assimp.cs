using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "assimp-vc143-mt";
            }

            return "libassimp";
        }
    }
}