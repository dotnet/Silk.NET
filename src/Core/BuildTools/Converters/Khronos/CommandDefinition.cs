using System;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class CommandDefinition
    {
        public string Name { get; }
        public TypeSpec ReturnType { get; }
        public ParameterDefinition[] Parameters { get; }
        public string[] SuccessCodes { get; }
        public string[] ErrorCodes { get; }

        public CommandDefinition(string name, TypeSpec returnType, ParameterDefinition[] parameters, string[] successCodes, string[] errorCodes)
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
                
                return new CommandDefinition(ret.Name, ret.ReturnType, ret.Parameters, ret.SuccessCodes, ret.ErrorCodes);
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
                .Select(paramXml => ParameterDefinition.CreateFromXml(paramXml)).ToArray();

            return new CommandDefinition(name, returnType, parameters, successCodes, errorCodes);
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
