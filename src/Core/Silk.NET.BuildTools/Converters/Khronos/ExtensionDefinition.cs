// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    /// <summary>
    /// A definition of an extension.
    /// </summary>
    public class ExtensionDefinition
    {
        /// <summary>
        /// The name of the extension.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The number of the extension.
        /// </summary>
        public int Number { get; }
        
        /// <summary>
        /// The extension type.
        /// </summary>
        public string Type { get; }
        
        /// <summary>
        /// The constants in the extension.
        /// </summary>
        public ExtensionConstant[] Constants { get; }
        
        /// <summary>
        /// The enums in the extension.
        /// </summary>
        public EnumExtensionValue[] EnumExtensions { get; }
        
        /// <summary>
        /// The command names in the extension.
        /// </summary>
        public string[] CommandNames { get; }
        
        /// <summary>
        /// The type names in the extension.
        /// </summary>
        public string[] TypeNames { get; }
        
        /// <summary>
        /// A list of supported strings in the extension.
        /// </summary>
        public string[] Supported { get; }

        /// <summary>
        /// Create a new extension definition.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="number">The number.</param>
        /// <param name="type">The type.</param>
        /// <param name="constants">The constants.</param>
        /// <param name="enumExtensions">The enum extensions.</param>
        /// <param name="commandNames">The command names.</param>
        /// <param name="typeNames">The type names.</param>
        /// <param name="supported">A list of supported strings.</param>
        public ExtensionDefinition(
            string name,
            int number,
            string type,
            ExtensionConstant[] constants,
            EnumExtensionValue[] enumExtensions,
            string[] commandNames,
            string[] typeNames,
            string[] supported)
        {
            Name = name;
            Number = number;
            Type = type;
            Constants = constants;
            EnumExtensions = enumExtensions;
            CommandNames = commandNames;
            TypeNames = typeNames;
            Supported = supported;
        }

        /// <summary>
        /// Create an ExtensionDefinition from an XML element.
        /// </summary>
        /// <param name="xe">The XML element.</param>
        /// <returns>The extension definition.</returns>
        public static ExtensionDefinition CreateFromXml(XElement xe)
        {
            var name = xe.GetNameAttribute();
            var numberString = xe.Attribute("number")?.Value ?? throw new InvalidDataException();
            var number = int.Parse(numberString);
            var type = xe.GetTypeAttributeOrNull();
            var extensionConstants = new List<ExtensionConstant>();
            var enumExtensions = new List<EnumExtensionValue>();
            var commandNames = new List<string>();
            var typeNames = new List<string>();
            var supported = xe.Attribute("supported")?.Value.Split('|').SelectMany(x => x.Split(',')).ToArray();

            foreach (var require in xe.Elements("require"))
            {
                foreach (var enumXe in require.Elements("enum"))
                {
                    ParseEnumRequirement(enumXe, number, enumExtensions, name, extensionConstants);
                }

                commandNames.AddRange(require.Elements("command").Select
                (
                    commandXe => commandXe.GetNameAttribute())
                );

                typeNames.AddRange(require.Elements("type").Select
                (
                    typeXe => typeXe.GetNameAttribute())
                );
            }
            
            return new ExtensionDefinition
            (
                name,
                number,
                type,
                extensionConstants.ToArray(),
                enumExtensions.ToArray(),
                commandNames.ToArray(),
                typeNames.ToArray(),
                supported
            );
        }

        private static void ParseEnumRequirement(XElement enumXe, int originalNumber, ICollection<EnumExtensionValue> enumExtensions, string name, ICollection<ExtensionConstant> extensionConstants)
        {
            Debug.Assert(enumXe.Document != null, "enumXe.Document != null");
            var registry = enumXe.Document.Element("registry") ?? throw new InvalidDataException();
            
            var enumName = enumXe.GetNameAttribute();

            var number = enumXe.Attribute("extnumber") is null
                ? originalNumber
                : int.Parse(enumXe.Attribute("extnumber")?.Value ?? throw new InvalidDataException());

            if (!(enumXe.Attribute("alias") is null))
            {
                var dummyValues = new List<EnumExtensionValue>();
                var dummyConstants = new List<ExtensionConstant>();
                
                ParseEnumRequirement
                (
                    registry
                        .Elements("extensions")
                        .Elements("extension")
                        .Concat(registry.Elements("feature"))
                        .Elements("require")
                        .Elements("enum")
                        .Concat(registry.Elements("enums").Elements("enum"))
                        .FirstOrDefault(x => x.GetNameAttribute() == enumXe.Attribute("alias")?.Value), number,
                    dummyValues, name, dummyConstants
                );
                
                foreach (var dummyValue in dummyValues)
                {
                    enumExtensions.Add(new EnumExtensionValue(dummyValue.ExtendedType, enumName, dummyValue.Value));
                }

                foreach (var dummyConstant in dummyConstants)
                {
                    extensionConstants.Add(new ExtensionConstant(enumName, dummyConstant.Value));
                }
                
                return;
            }

            var extends = enumXe.Attribute("extends")?.Value;
            if (extends != null)
            {
                string valueString;
                var offsetString = enumXe.Attribute("offset")?.Value;
                if (offsetString != null)
                {
                    var offset = int.Parse(offsetString);
                    var direction = 1;
                    if (enumXe.Attribute("dir")?.Value == "-")
                    {
                        direction = -1;
                    }

                    var value = direction * (1000000000 + (number - 1) * 1000 + offset);
                    valueString = value.ToString();
                }
                else
                {
                    var bitPosString = enumXe.Attribute("bitpos")?.Value;
                    if (bitPosString != null)
                    {
                        var shift = int.Parse(bitPosString);
                        valueString = (1L << shift).ToString();
                    }
                    else
                    {
                        valueString = enumXe.Attribute("value")?.Value;
                    }
                }
                enumExtensions.Add(new EnumExtensionValue(extends, enumName, valueString));
            }
            else
            {
                var valueAttribute = enumXe.Attribute("value");
                if (valueAttribute == null)
                    return;

                extensionConstants.Add(new ExtensionConstant(enumName, valueAttribute.Value));
            }
        }
    }

    /// <summary>
    /// A constant defined in an extension.
    /// </summary>
    public class ExtensionConstant
    {
        /// <summary>
        /// The constant name.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The constant value.
        /// </summary>
        public string Value { get; }
        
        /// <summary>
        /// Create a new ExpressionConstant.
        /// </summary>
        /// <param name="name">The constant name.</param>
        /// <param name="value">The constant value.</param>
        public ExtensionConstant(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }

    /// <summary>
    /// The value of an enum, defined in an extension.
    /// </summary>
    [DebuggerDisplay("{" + nameof(DebuggerDisplayString) + "}")]
    public class EnumExtensionValue
    {
        /// <summary>
        /// The type of the enum.
        /// </summary>
        public string ExtendedType { get; }
        
        /// <summary>
        /// The name of the enum value.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// The enum value.
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Create a new EnumExtensionValue.
        /// </summary>
        /// <param name="extendedType">The type of the enum.</param>
        /// <param name="name">The name of the enum value.</param>
        /// <param name="value">The enum value.</param>
        public EnumExtensionValue(string extendedType, string name, string value)
        {
            ExtendedType = extendedType;
            Name = name;
            Value = value;
        }

        private string DebuggerDisplayString =>
            $"Ext: {ExtendedType}, {Name} = {Value}";
    }
}
