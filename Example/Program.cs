// See https://aka.ms/new-console-template for more information
using Hexa.NET.Assimp;

Console.WriteLine("Hello, World!");

unsafe
{
    var scene = Assimp.ImportFile("Box.glb", (uint)(AiImporterFlags.SupportBinaryFlavour | AiImporterFlags.SupportTextFlavour | AiImporterFlags.SupportCompressedFlavour));
}