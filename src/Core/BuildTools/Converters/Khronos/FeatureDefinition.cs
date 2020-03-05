using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class FeatureDefinition
    {
        public string Name { get; }
        public Version Number { get; }
        public string Api { get; }
        public string[] EnumNames { get; }
        public string[] CommandNames { get; }
        public string[] TypeNames { get; }
        public EnumExtensionValue[] EnumExtensions { get; }

        public FeatureDefinition(
            string name,
            Version number,
            string api,
            string[] enumNames,
            string[] commandNames,
            string[] typeNames,
            EnumExtensionValue[] extVals)
        {
            Name = name;
            Number = number;
            Api = api;
            EnumNames = enumNames;
            CommandNames = commandNames;
            TypeNames = typeNames;
            EnumExtensions = extVals;
        }

        public static FeatureDefinition CreateFromXml(XElement xe)
        {
            string name = xe.GetNameAttribute();
            string numberString = xe.Attribute("number").Value;
            Version number = Version.Parse(numberString);
            string api = xe.Attribute("api")?.Value;
            List<string> enumNames = new List<string>();
            List<string> commandNames = new List<string>();
            List<string> typeNames = new List<string>();
            var enumExtensionValues = new List<EnumExtensionValue>();

            foreach (var require in xe.Elements("require"))
            {
                foreach (var enumXE in require.Elements("enum"))
                {
                    enumNames.Add(ParseEnumRequirement(enumXE, 0, enumExtensionValues));
                }
                foreach (var commandXE in require.Elements("command"))
                {
                    commandNames.Add(commandXE.GetNameAttribute());
                }
                foreach (var typeXE in require.Elements("type"))
                {
                    commandNames.Add(typeXE.GetNameAttribute());
                }
            }

            return new FeatureDefinition
            (
                name, number, api, enumNames.ToArray(), commandNames.ToArray(), typeNames.ToArray(),
                enumExtensionValues.ToArray()
            );
        }

        private static string ParseEnumRequirement(XElement enumXE, int ognumber, List<EnumExtensionValue> enumExtensions)
        {
            string enumName = enumXE.GetNameAttribute();

            var number = enumXE.Attribute("extnumber") is null
                ? ognumber
                : int.Parse(enumXE.Attribute("extnumber").Value);

            if (!(enumXE.Attribute("alias") is null))
            {
                var dummyValues = new List<EnumExtensionValue>();
                ParseEnumRequirement
                (
                    enumXE.Document.Element("registry")
                        .Elements("extensions")
                        .Elements("extension")
                        .Concat(enumXE.Document.Element("registry").Elements("feature"))
                        .Elements("require")
                        .Elements("enum")
                        .Concat(enumXE.Document.Element("registry").Elements("enums").Elements("enum"))
                        .FirstOrDefault(x => x.GetNameAttribute() == enumXE.Attribute("alias").Value), number,
                    dummyValues
                );
                foreach (var dummyValue in dummyValues)
                {
                    enumExtensions.Add(new EnumExtensionValue(dummyValue.ExtendedType, enumName, dummyValue.Value));
                }
                
                return enumName;
            }

            string extends = enumXE.Attribute("extends")?.Value;
            if (extends != null)
            {
                string valueString;
                string offsetString = enumXE.Attribute("offset")?.Value;
                if (offsetString != null)
                {
                    int offset = int.Parse(offsetString);
                    int direction = 1;
                    if (enumXE.Attribute("dir")?.Value == "-")
                    {
                        direction = -1;
                    }

                    int value = direction * (1000000000 + (number - 1) * 1000 + offset);
                    valueString = value.ToString();
                }
                else
                {
                    string bitPosString = enumXE.Attribute("bitpos")?.Value;
                    if (bitPosString != null)
                    {
                        int shift = int.Parse(bitPosString);
                        valueString = (1 << shift).ToString();
                    }
                    else
                    {
                        valueString = enumXE.Attribute("value").Value;
                    }
                }
                enumExtensions.Add(new EnumExtensionValue(extends, enumName, valueString));
            }

            return enumName;
        }
    }
}
