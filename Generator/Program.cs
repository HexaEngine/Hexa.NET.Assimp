using HexaGen;
using HexaGen.Patching;
using System.Text.RegularExpressions;
using System.Text;
using HexaGen.GenerationSteps;
using Generator;

List<string> files = [.. Directory.GetFiles("include", "*.h")];
files.RemoveAll(x => x.Contains("XmlParser.h") || x.Contains("ZipArchiveIOSystem.h"));
Regex regex = new("^#include <assimp/(.*)>", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);

var hFiles = Directory.GetFiles("include");
for (int i = 0; i < hFiles.Length; i++)
{
    string file = hFiles[i];
    var content = File.ReadAllText(file);
    StringBuilder sb = new(content);
    int offset = 0;
    foreach (Match match in regex.Matches(content))
    {
        sb.Remove(match.Index + offset, match.Length);
        string replacement = $"#include \"{match.Groups[1].Value}\"";
        sb.Insert(match.Index + offset, replacement);
        offset += replacement.Length - match.Length;
        files.Add(Path.GetFullPath($"include/{match.Groups[1].Value}"));
    }
    sb.Replace("#cmakedefine", "#define");
    File.WriteAllText(file, sb.ToString());
}

BatchGenerator batch = new();
batch.Setup<CsCodeGenerator>("generator.json");
batch.AlterGenerator(g =>
{
    var step = g.GetGenerationStep<ConstantGenerationStep>();
    int index = g.GenerationSteps.IndexOf(step);
    g.GenerationSteps.RemoveAt(index);
    g.GenerationSteps.Insert(index, new AssimpConstantGenerationStep(g, g.Settings));
});
batch.AddPrePatch(new NamingPatch(["Ai"], NamingPatchOptions.None));
batch.Generate([.. files], "../../../../Hexa.NET.Assimp/Generated");