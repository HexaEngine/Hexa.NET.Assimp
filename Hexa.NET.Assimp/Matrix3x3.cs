namespace Hexa.NET.Assimp
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public partial struct Matrix3x3
    {
        public float A1, A2, A3;
        public float B1, B2, B3;
        public float C1, C2, C3;

        public Matrix3x3(float a1, float a2, float a3, float b1, float b2, float b3, float c1, float c2, float c3)
        {
            A1 = a1;
            A2 = a2;
            A3 = a3;
            B1 = b1;
            B2 = b2;
            B3 = b3;
            C1 = c1;
            C2 = c2;
            C3 = c3;
        }
    }
}