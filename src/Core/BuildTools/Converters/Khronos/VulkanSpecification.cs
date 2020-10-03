using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class VulkanSpecification
    {
        public CommandDefinition[] Commands { get; }
        public ConstantDefinition[] Constants { get; }
        public TypedefDefinition[] Typedefs { get; }
        public EnumDefinition[] Enums { get; }
        public StructureDefinition[] Structures { get; }
        public StructureDefinition[] Unions { get; }
        public HandleDefinition[] Handles { get; }
        public Dictionary<string, string> BaseTypes { get; }
        public ExtensionDefinition[] Extensions { get; }
        public FeatureDefinition[] Features { get; }

        public VulkanSpecification(
            CommandDefinition[] commands,
            ConstantDefinition[] constants,
            TypedefDefinition[] typedefs,
            EnumDefinition[] enums,
            StructureDefinition[] structures,
            StructureDefinition[] unions,
            HandleDefinition[] handles,
            Dictionary<string, string> baseTypes,
            ExtensionDefinition[] extensions,
            FeatureDefinition[] features)
        {
            Commands = commands;
            Constants = constants;
            Typedefs = typedefs;
            Enums = enums;
            Structures = structures;
            Unions = unions;
            Handles = handles;
            BaseTypes = baseTypes;
            Extensions = extensions;
            Features = features;
            AddExtensionEnums(Enums, Extensions);
            AddExtensionEnums(Enums, Features);
        }

        public static VulkanSpecification LoadFromXmlStream(Stream specFileStream)
        {
            var spec = XDocument.Load(specFileStream);
            var registry = spec.Element("registry");
            var commands = registry.Element("commands");
            var commandDefinitions = commands.Elements("command")
                .Select(commandx => CommandDefinition.CreateFromXml(commandx)).ToArray();

            var constantDefinitions = registry.Elements("enums")
                .Where(enumx => enumx.Attribute("name").Value == "API Constants")
                .SelectMany(enumx => enumx.Elements("enum"))
                .Select(enumxx => ConstantDefinition.CreateFromXml(enumxx)).ToArray();

            var types = registry.Elements("types");
            var typedefDefinitions = types.Elements("type").Where(xe => xe.Value.Contains("typedef") && xe.HasCategoryAttribute("bitmask"))
                .Select(xe2 => TypedefDefinition.CreateFromXml(xe2)).ToArray();

            var enumDefinitionsNoAliases = registry.Elements("enums")
                .Where(enumx => enumx.GetTypeAttributeOrNull() == "enum" || enumx.GetTypeAttributeOrNull() == "bitmask")
                .Select(enumx => EnumDefinition.CreateFromXml(enumx))
                .ToArray();

            var enumDefinitions = registry.Elements("types")
                .Elements("type")
                .Where(xe => xe.HasCategoryAttribute("enum") && !(xe.Attribute("alias") is null))
                .Select
                (
                    x => enumDefinitionsNoAliases.First(y => y.Name == x.Attribute("alias")?.Value)
                        .Clone(x.GetNameAttribute())
                )
                .Concat(enumDefinitionsNoAliases)
                .ToArray();

            var structures = types.Elements("type").Where(typex => typex.HasCategoryAttribute("struct"))
                .Select(typex => StructureDefinition.CreateFromXml(typex)).ToArray();

            var unions =
                types.Elements("type")
                .Where(typex => typex.HasCategoryAttribute("union"))
                .Select(typex => StructureDefinition.CreateFromXml(typex)).ToArray();

            var handles = types.Elements("type").Where(typex => typex.HasCategoryAttribute("handle"))
                .Select(typex => HandleDefinition.CreateFromXml(typex)).ToArray();

            var baseTypes = types.Elements("type").Where(typex => typex.HasCategoryAttribute("basetype"))
                .ToDictionary(
                    typex => typex.GetNameElement(),
                    typex => typex.Element("type")?.Value ?? "IntPtr");
            baseTypes["VkBool32"] = "Bool32";

            var extensions = registry.Element("extensions").Elements("extension")
                .Select(ExtensionDefinition.CreateFromXml).ToArray();

            var features = registry.Elements("feature")
                .Select(FeatureDefinition.CreateFromXml)
                .ToArray();

            return new VulkanSpecification(
                commandDefinitions,
                constantDefinitions,
                typedefDefinitions,
                enumDefinitions,
                structures,
                unions,
                handles,
                baseTypes,
                extensions,
                features);
        }

        private void AddExtensionEnums(EnumDefinition[] enums, ExtensionDefinition[] extensions)
        {
            foreach (var exDef in extensions)
            {
                if (exDef.Name == "VK_KHX_device_group")
                {

                }

                foreach (var enumEx in exDef.EnumExtensions)
                {
                    var enumDef = GetEnumDef(enums, enumEx.ExtendedType);
                    var value = int.Parse(enumEx.Value);
                    enumDef.Values = enumDef.Values.Append(new EnumValue(enumEx.Name, value, null)).ToArray();
                }
            }
        }

        private void AddExtensionEnums(EnumDefinition[] enums, FeatureDefinition[] extensions)
        {
            foreach (var exDef in extensions)
            {
                foreach (var enumEx in exDef.EnumExtensions)
                {
                    var enumDef = GetEnumDef(enums, enumEx.ExtendedType);
                    var value = int.Parse(enumEx.Value);
                    enumDef.Values = enumDef.Values.Append(new EnumValue(enumEx.Name, value, null)).ToArray();
                }
            }
        }

        private EnumDefinition GetEnumDef(EnumDefinition[] enums, string name)
        {
            return enums.Single(ed => ed.Name == name);
        }
    }
}
