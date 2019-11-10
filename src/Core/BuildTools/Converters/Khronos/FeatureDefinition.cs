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
        public string[] EnumNames { get; }
        public string[] CommandNames { get; }
        public string[] TypeNames { get; }

        public FeatureDefinition(
            string name,
            Version number,
            string api,
            string[] enumNames,
            string[] commandNames,
            string[] typeNames)
        {
            Name = name;
            Number = number;
            Api = api;
            EnumNames = enumNames;
            CommandNames = commandNames;
            TypeNames = typeNames;
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

            foreach (var require in xe.Elements("require"))
            {
                foreach (var enumXE in require.Elements("enum"))
                {
                    enumNames.Add(enumXE.GetNameAttribute());
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
            return new FeatureDefinition(name, number, api, enumNames.ToArray(), commandNames.ToArray(), typeNames.ToArray());
        }
    }
}
