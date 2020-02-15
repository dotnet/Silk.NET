using System;
using System.Linq;
using System.Xml.Linq;
using JetBrains.Annotations;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class CommandDefinition
    {
        public string Name { get; }
        public TypeSpec ReturnType { get; }
        public ParameterDefinition[] Parameters { get; }
        public string[] SuccessCodes { get; }
        public string[] ErrorCodes { get; }

        public CommandDefinition
        (
            string name,
            TypeSpec returnType,
            ParameterDefinition[] parameters,
            string[] successCodes,
            string[] errorCodes
        )
        {
            Require.NotNull(parameters);
            Require.NotNull(successCodes);
            Require.NotNull(errorCodes);

            Name = name;
            ReturnType = returnType;
            Parameters = parameters;
            SuccessCodes = successCodes;
            ErrorCodes = errorCodes;
        }

        public static CommandDefinition CreateFromXml(XElement xe)
        {
            Require.Equal("command", xe.Name);

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (
                    xe.Document.Element("registry")
                        .Elements("commands")
                        .Elements("command")
                        .FirstOrDefault(x => x.Element("proto")?.Element("name")?.Value == xe.Attribute("alias").Value)
                );

                return new CommandDefinition
                    (xe.GetNameAttribute(), ret.ReturnType, ret.Parameters, ret.SuccessCodes, ret.ErrorCodes);
            }

            var proto = xe.Element("proto");
            string name = proto.Element("name").Value;
            string returnTypeName = proto.Element("type").Value;
            TypeSpec returnType = new TypeSpec(returnTypeName);

            var successAttr = xe.Attribute("successcodes");
            string[] successCodes = successAttr != null
                ? successAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();

            var errorAttr = xe.Attribute("errorcodes");
            string[] errorCodes = errorAttr != null
                ? errorAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();

            ParameterDefinition[] parameters = xe.Elements("param")
                .Select(paramXml => ParameterDefinition.CreateFromXml(paramXml))
                .ToArray();

            return new CommandDefinition(name, returnType, Vary(parameters, name), successCodes, errorCodes);
        }

        [Pure]
        private static ParameterDefinition[] Vary(ParameterDefinition[] p, string name)
        {
            for (var i = 0; i < p.Length; i++)
            {
                var param = p[i];
                if (param.Type.PointerIndirection > 0 && param.Type.Name != "void")
                {
                    if (param.IsConst)
                    {
                        p[i] = new ParameterDefinition
                        (
                            param.Name, new TypeSpec(param.Type.Name, param.Type.PointerIndirection),
                            ParameterModifier.In, param.IsOptional, param.ElementCount, param.ElementCountSymbolic,
                            param.IsConst
                        );
                    }
                    else if ((name.StartsWith("vkCreate") || name.StartsWith("vkAllocate") || name.StartsWith
                                 ("vkGet")) &&
                             i == p.Length - 1)
                    {
                        // DO NOT CHANGE THE TYPE HERE, it will be done by the FlowPointerOverloader.
                        p[i] = new ParameterDefinition
                        (
                            param.Name, new TypeSpec(param.Type.Name, param.Type.PointerIndirection),
                            ParameterModifier.Out, param.IsOptional, param.ElementCount, param.ElementCountSymbolic,
                            param.IsConst
                        );
                    }
                    else
                    {
                        p[i] = new ParameterDefinition
                        (
                            param.Name, new TypeSpec(param.Type.Name, param.Type.PointerIndirection),
                            ParameterModifier.Ref, param.IsOptional, param.ElementCount, param.ElementCountSymbolic,
                            param.IsConst
                        );
                    }
                }
            }

            return p;
        }

        public string GetParametersSignature()
        {
            return string.Join(", ", Parameters.Select(pd => pd.ToString()));
        }

        public override string ToString()
        {
            string paramSig = GetParametersSignature();
            return $"{ReturnType} {Name}({paramSig})";
        }
    }
}
