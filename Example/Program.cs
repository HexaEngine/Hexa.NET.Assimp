// See https://aka.ms/new-console-template for more information
using Hexa.NET.Assimp;
using System.Runtime.InteropServices;
using System.Text;

Console.WriteLine("Hello, World!");

unsafe
{
    AiLogStream stream = new(Log);
    Assimp.AttachLogStream(&stream);
    var scene = Assimp.ImportFile("C:\\Users\\junam\\Documents\\HexaEngine\\Projects\\New Project\\assets\\FlightHelmet.gltf", (uint)(AiImporterFlags.SupportBinaryFlavour | AiImporterFlags.SupportTextFlavour | AiImporterFlags.SupportCompressedFlavour));
}

unsafe void Log(byte* message, byte* unknown1)
{
    string msg = Encoding.UTF8.GetString(MemoryMarshal.CreateReadOnlySpanFromNullTerminated(message));
}