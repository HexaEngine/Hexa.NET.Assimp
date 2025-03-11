using System.Text;

namespace Hexa.NET.Assimp
{
    public unsafe partial struct AiString
    {
        public AiString(string str)
        {
            fixed (AiString* self = &this)
            fixed (char* p = str)
            {
                Encoding.UTF8.GetBytes(p, str.Length, &self->Data_0, 1024);
            }
        }

        public static implicit operator string(AiString str)
        {
            return new string((sbyte*)&str.Data_0, 0, (int)str.Length);
        }

        public override string ToString()
        {
            return this;
        }
    }
}