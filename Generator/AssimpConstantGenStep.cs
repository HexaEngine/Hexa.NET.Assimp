using CppAst;
using HexaGen;
using HexaGen.GenerationSteps;
using HexaGen.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class AssimpConstantGenerationStep : ConstantGenerationStep
    {
        private EnumPrefix aiTextureTypePrefix;
        private string aiTextureTypeCsName;

        public AssimpConstantGenerationStep(CsCodeGenerator generator, CsCodeGeneratorConfig config) : base(generator, config)
        {
        }

        public override void Configure(CsCodeGeneratorConfig config)
        {
            base.Configure(config);
            aiTextureTypePrefix = config.GetEnumNamePrefixEx("aiTextureType");
            aiTextureTypeCsName = config.GetCsCleanName("aiTextureType");
        }

        protected override CsConstantMetadata ParseConstant(CppMacro macro)
        {
            var meta = base.ParseConstant(macro);
            string text = macro.Value.NormalizeConstantValue();
            if (meta.Type == CsConstantType.Unknown && text.StartsWith('\"'))
            {
                var span = text.AsSpan();
                int i = span.LastIndexOf('\"');
                if (i != -1)
                {
                    span = span[..(i + 1)];
                    meta.Value = span.ToString();
                    meta.Type = CsConstantType.String;
                }
            }
            if (text.StartsWith("aiTextureType_"))
            {
                var len = text.IndexOf(',');
                if (len == -1) len = text.Length;
                var name = config.GetEnumNameEx(text.Substring(0, len), aiTextureTypePrefix);
                var reference = $"{aiTextureTypeCsName}.{name}";
                meta.Value = reference;
                meta.Type = CsConstantType.Custom;
                meta.CustomType = aiTextureTypeCsName;
            }

            return meta;
        }
    }
}