// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    /// <summary>
    /// Defines a feature.
    /// </summary>
    public class FeatureDefinition
    {
        /// <summary>
        /// Name of the feature.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Version number of the feature.
        /// </summary>
        public Version Number { get; }

        /// <summary>
        /// API of the feature.
        /// </summary>
        public string Api { get; }

        /// <summary>
        /// Enum names of the feature.
        /// </summary>
        public string[] EnumNames { get; }

        /// <summary>
        /// Command names of the feature.
        /// </summary>
        public string[] CommandNames { get; }

        /// <summary>
        /// Type names of the feature.
        /// </summary>
        public string[] TypeNames { get; }

        /// <summary>
        /// Enum extensions in the feature.
        /// </summary>
        public EnumExtensionValue[] EnumExtensions { get; }

        /// <summary>
        /// Create a new FeatureDefinition.
        /// </summary>
        /// <param name="name">The name of the feature.</param>
        /// <param name="number">The version number.</param>
        /// <param name="api">The API.</param>
        /// <param name="enumNames">The enum names.</param>
        /// <param name="commandNames">The command names.</param>
        /// <param name="typeNames">The type names.</param>
        /// <param name="extensionValues">Enum extension values.</param>
        public FeatureDefinition(
            string name,
            Version number,
            string api,
            string[] enumNames,
            string[] commandNames,
            string[] typeNames,
            EnumExtensionValue[] extensionValues)
        {
            Name = name;
            Number = number;
            Api = api;
            EnumNames = enumNames;
            CommandNames = commandNames;
            TypeNames = typeNames;
            EnumExtensions = extensionValues;
        }

        /// <summary>
        /// Create a FeatureDefinition from an XML element.
        /// </summary>
        /// <param name="xe">The element to create.</param>
        /// <returns>The created definition.</returns>
        public static FeatureDefinition CreateFromXml(XElement xe)
        {
            var name = xe.GetNameAttribute();
            var numberString = xe.Attribute("number")?.Value ?? throw new InvalidDataException();
            var number = Version.Parse(numberString);
            var api = xe.Attribute("api")?.Value;
            var enumNames = new List<string>();
            var commandNames = new List<string>();
            var typeNames = new List<string>();
            var enumExtensionValues = new List<EnumExtensionValue>();

            foreach (var require in xe.Elements("require"))
            {
                enumNames.AddRange(require.Elements("enum")
                    .Select(x => ParseEnumRequirement(x, 0, enumExtensionValues)));

                commandNames.AddRange(require.Elements("command")
                    .Select(x => x.GetNameAttribute()));

                commandNames.AddRange(require.Elements("type")
                    .Select(x => x.GetNameAttribute()));
            }

            return new FeatureDefinition
            (
                name, number, api, enumNames.ToArray(), commandNames.ToArray(), typeNames.ToArray(),
                enumExtensionValues.ToArray()
            );
        }

        private static string ParseEnumRequirement(XElement enumXe, int originalNumber, ICollection<EnumExtensionValue> enumExtensions)
        {
            var enumName = enumXe.GetNameAttribute();

            Debug.Assert(enumXe.Document != null);

            var number = enumXe.Attribute("extnumber") is null
                ? originalNumber
                : int.Parse(enumXe.Attribute("extnumber")?.Value ?? throw new InvalidDataException());

            if (!(enumXe.Attribute("alias") is null))
            {
                var dummyValues = new List<EnumExtensionValue>();
                ParseEnumRequirement
                (
                    enumXe.Document.Element("registry")
                        ?.Elements("extensions")
                        .Elements("extension")
                        .Concat(enumXe.Document.Element("registry")?.Elements("feature")
                                ?? throw new InvalidDataException())
                        .Elements("require")
                        .Elements("enum")
                        .Concat(enumXe.Document.Element("registry")?.Elements("enums").Elements("enum")
                                ?? throw new InvalidDataException())
                        .FirstOrDefault(x => x.GetNameAttribute() == enumXe.Attribute("alias")?.Value), number,
                    dummyValues
                );
                foreach (var dummyValue in dummyValues)
                {
                    enumExtensions.Add(new EnumExtensionValue(dummyValue.ExtendedType, enumName, dummyValue.Value));
                }

                return enumName;
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
                        valueString = (1 << shift).ToString();
                    }
                    else
                    {
                        valueString = enumXe.Attribute("value")?.Value;
                    }
                }
                enumExtensions.Add(new EnumExtensionValue(extends, enumName, valueString));
            }

            return enumName;
        }
    }
}
