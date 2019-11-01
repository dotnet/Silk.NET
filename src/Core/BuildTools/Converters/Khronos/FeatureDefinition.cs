using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class FeatureDefinition
    {
        public string Name { get; }
        public Version Number { get; }
        public string Api { get; }
        public ExtensionConstant[] Constants { get; }
        public EnumExtensionValue[] EnumExtensions { get; }
        public string[] CommandNames { get; }
        public string[] TypeNames { get; }

        public FeatureDefinition(
            string name,
            Version number,
            string api,
            ExtensionConstant[] constants,
            EnumExtensionValue[] enumExtensions,
            string[] commandNames,
            string[] typeNames)
        {
            Name = name;
            Number = number;
            Api = api;
            Constants = constants;
            EnumExtensions = enumExtensions;
            CommandNames = commandNames;
        }

        public static FeatureDefinition CreateFromXml(XElement xe)
        {
            string name = xe.GetNameAttribute();
            string numberString = xe.Attribute("number").Value;
            Version number = Version.Parse(numberString);
            string api = xe.Attribute("api")?.Value;
            List<ExtensionConstant> extensionConstants = new List<ExtensionConstant>();
            List<EnumExtensionValue> enumExtensions = new List<EnumExtensionValue>();
            List<string> commandNames = new List<string>();
            List<string> typeNames = new List<string>();

            foreach (var require in xe.Elements("require"))
            {
                foreach (var enumXE in require.Elements("enum"))
                {
                    string enumName = enumXE.GetNameAttribute();
                    string extends = enumXE.Attribute("extends")?.Value;
                    var extNumber = int.Parse(enumXE.Attribute("extnumber")?.Value);
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

                            int value = direction * (1000000000 + (extNumber - 1) * 1000 + offset);
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
                    else
                    {
                        var valueAttribute = enumXE.Attribute("value");
                        if (valueAttribute == null)
                            continue;

                        extensionConstants.Add(new ExtensionConstant(name, valueAttribute.Value));
                    }
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
            return new FeatureDefinition(name, number, api, extensionConstants.ToArray(), enumExtensions.ToArray(), commandNames.ToArray(), typeNames.ToArray());
        }
    }
}
