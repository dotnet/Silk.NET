using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Xml.Linq;

using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    /// <summary>
    /// Defines a command.
    /// </summary>
    public class CommandDefinition
    {
        /// <summary>
        /// The command type.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The return type of the command.
        /// </summary>
        public TypeSpec ReturnType { get; }
        
        /// <summary>
        /// The parameters of the command.
        /// </summary>
        public ParameterDefinition[] Parameters { get; }
        
        /// <summary>
        /// Success codes of the command.
        /// </summary>
        public string[] SuccessCodes { get; }
        
        /// <summary>
        /// Error codes of the command.
        /// </summary>
        public string[] ErrorCodes { get; }

        /// <summary>
        /// The specific API this function is applicable to.
        /// </summary>
        public string? Api { get; }

        /// <summary>
        /// Create a new command definition.
        /// </summary>
        /// <param name="name">The name of the command.</param>
        /// <param name="returnType">The return type of the command.</param>
        /// <param name="parameters">The parameters of the command.</param>
        /// <param name="successCodes">Success codes of the command.</param>
        /// <param name="errorCodes">Error codes of the command.</param>
        public CommandDefinition
        (
            string name,
            TypeSpec returnType,
            ParameterDefinition[] parameters,
            string[] successCodes,
            string[] errorCodes,
            string? api
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
            Api = api;
        }

        /// <summary>
        /// Create a command definition from XML.
        /// </summary>
        /// <param name="xe">The element to use.</param>
        /// <returns>The command definition.</returns>
        public static CommandDefinition CreateFromXml(XElement xe)
        {
            Require.Equal("command", xe.Name);

            if (!(xe.Attribute("alias") is null))
            {
                var ret = CreateFromXml
                (
                    xe.Document?.Element("registry")
                        ?.Elements("commands")
                        .Elements("command")
                        .FirstOrDefault(x => x.Element("proto")?.Element("name")?.Value == xe.Attribute("alias")?.Value)
                );

                return new CommandDefinition
                    (xe.GetNameAttribute(), ret.ReturnType, ret.Parameters, ret.SuccessCodes, ret.ErrorCodes, ret.Api);
            }

            var proto = xe.Element("proto");
            var name = proto?.Element("name")?.Value;
            var returnTypeName = proto?.Element("type")?.Value;
            var returnType = new TypeSpec(returnTypeName);

            // ReSharper disable StringLiteralTypo
            var successAttr = xe.Attribute("successcodes");
            var successCodes = successAttr != null
                ? successAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();
            
            var errorAttr = xe.Attribute("errorcodes");
            var errorCodes = errorAttr != null
                ? errorAttr.Value.Split(',').ToArray()
                : Array.Empty<string>();

            var api = xe.Attribute("api")?.Value;
            
            // ReSharper restore StringLiteralTypo

            var parameters = xe.Elements("param")
                .Select(ParameterDefinition.CreateFromXml)
                .ToArray();

            return new CommandDefinition(name, returnType, Vary(parameters, name), successCodes, errorCodes, api);
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
                            param.IsConst, param.Api
                        );
                    }
                    else if (name.ConstitutesVulkanOutOverload() && i == p.Length - 1)
                    {
                        // DO NOT CHANGE THE TYPE HERE, it will be done by the FlowPointerOverloader.
                        p[i] = new ParameterDefinition
                        (
                            param.Name, new TypeSpec(param.Type.Name, param.Type.PointerIndirection),
                            ParameterModifier.Out, param.IsOptional, param.ElementCount, param.ElementCountSymbolic,
                            param.IsConst, param.Api
                        );
                    }
                    else
                    {
                        p[i] = new ParameterDefinition
                        (
                            param.Name, new TypeSpec(param.Type.Name, param.Type.PointerIndirection),
                            ParameterModifier.Ref, param.IsOptional, param.ElementCount, param.ElementCountSymbolic,
                            param.IsConst, param.Api
                        );
                    }
                }
            }

            return p;
        }

        /// <summary>
        /// Get all parameters as a string.
        /// </summary>
        /// <returns>All parameters as a string.</returns>
        public string GetParametersSignature()
        {
            return string.Join(", ", Parameters.Select(pd => pd.ToString()));
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var paramSig = GetParametersSignature();
            return $"{ReturnType} {Name}({paramSig})";
        }
    }
}
