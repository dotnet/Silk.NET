using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    public class VulkanSpecification
    {
        public CommandDefinition[] Commands { get; private set;  }
        public ConstantDefinition[] Constants { get; }
        public TypedefDefinition[] Typedefs { get; }
        public EnumDefinition[] Enums { get; private set; }
        public StructureDefinition[] Structures { get; private set; }
        public StructureDefinition[] Unions { get; private set; }
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
            Structures = structures;
            Unions = unions;
            Handles = handles;
            BaseTypes = baseTypes;
            Extensions = extensions;
            Features = features;

            var wipEnums = enums.ToList();
            AddExtensionEnums(wipEnums, Extensions);
            AddExtensionEnums(wipEnums, Features);
            MixinEnumTypeFixups(wipEnums, Typedefs);
            
            Enums = enums.ToArray();
        }

        static long? ParseLong(string token)
        {
            return token.StartsWith("0x")
                ? long.TryParse(token[2..], NumberStyles.HexNumber, null, out var result) ? result : null
                : long.TryParse(token, out var result2)
                    ? result2
                    : null;
        }
        
        public static VulkanSpecification LoadFromXmlStream(Stream specFileStream)
        {
            var spec = XDocument.Load(specFileStream);
            var registry = spec.Element("registry");
            var commandDefinitions = registry.Elements("commands").Elements("command")
                .Select(commandx => CommandDefinition.CreateFromXml(commandx)).ToArray();

            var constantDefinitions = registry.Elements("enums")
                .Where(enumx => enumx.Attribute("name").Value == "API Constants")
                .SelectMany(enumx => enumx.Elements("enum"))
                .Select(enumxx => ConstantDefinition.CreateFromXml(enumxx))
                .Concat(
                    registry.Elements("types")
                        .Elements("type") 
                        .Where(x => x.HasCategoryAttribute("define"))
                        .Select(x => x.Element("name")?.Value is { Length: > 0 } nm &&
                            ParseLong(x.Value.Replace("#define", "").Replace(nm, "").Trim()) is {} val
                                ? new ConstantDefinition(nm, val.ToString(), "", null)
                                : null
                        )
                        .OfType<ConstantDefinition>()
                 ).ToArray();

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
                    typex => typex.Element("type")?.Value ?? "nint");
            baseTypes["VkBool32"] = "Bool32";

            var extensions = registry.Element("extensions").Elements("extension")
                .Select(ExtensionDefinition.CreateFromXml).ToArray();

            var features = registry.Elements("feature")
                .Select(FeatureDefinition.CreateFromXml)
                .SelectMany
                (
                    x => x.Api.Split(',')
                        .Select
                        (
                            y => new FeatureDefinition
                            (
                                x.Name, x.Number, y, x.EnumNames, x.CommandNames, x.TypeNames, x.EnumExtensions
                            )
                        )
                )
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

        private void AddExtensionEnums(List<EnumDefinition> enums, ExtensionDefinition[] extensions)
        {
            foreach (var exDef in extensions)
            {
                if (exDef.Name == "VK_KHX_device_group")
                {

                }

                foreach (var enumEx in exDef.EnumExtensions)
                {
                    var enumDef = GetEnumDef(enums, enumEx.ExtendedType);
                    var value = long.Parse(enumEx.Value);
                    foreach (var api in enumDef.Api?.Split(',') ?? exDef.Supported)
                    {
                        enumDef.Values = enumDef.Values.Append(new EnumValue(enumEx.Name, value, null, api)).ToArray();
                    }
                }
            }
        }

        private void AddExtensionEnums(List<EnumDefinition> enums, FeatureDefinition[] extensions)
        {
            foreach (var exDef in extensions)
            {
                foreach (var enumEx in exDef.EnumExtensions)
                {
                    var enumDef = GetEnumDef(enums, enumEx.ExtendedType);
                    var value = long.Parse(enumEx.Value);
                    enumDef.Values = enumDef.Values.Append(new EnumValue(enumEx.Name, value, null, exDef.Api)).ToArray();
                }
            }
        }
        
        private void MixinEnumTypeFixups(List<EnumDefinition> enums, TypedefDefinition[] typedefs)
        {
            foreach (var typedefDefinition in typedefs)
            {
                if (typedefDefinition.BitValues is not null)
                {
                    foreach (var enumDefinition in enums)
                    {
                        // if the bit width is default and we have a typedef for this enum
                        if ((enumDefinition.Name == typedefDefinition.Name ||
                            enumDefinition.Name == typedefDefinition.BitValues) &&
                            enumDefinition.BitWidth == 32)
                        {
                            enumDefinition.BitWidth = typedefDefinition.Type switch
                            {
                                "XrFlags64" => 64,
                                _ => 32
                            };
                        }
                    }
                }
            }
        }

        private EnumDefinition GetEnumDef(List<EnumDefinition> enums, string name)
        {
            var ret = enums.SingleOrDefault(ed => ed.Name == name);
            if (ret == default)
            {
                // bandage around the fact that khronos always slip up on their xml specs
                ret = EnumDefinition.CreateFromXml(XElement.Parse($"<enums name=\"{name}\" type=\"bitmask\" />"));
                enums.Add(ret);
            }

            return ret;
        }

        /// <summary>
        /// Specialises "partially specialised" functions and structures i.e. functions/structures that do not have an
        /// api-specific attribute present, but whose parameters/fields have api-specific attributes. Basically, this
        /// duplicates each function/structure but with only the relevant attributes included as if they were wholly
        /// redefined for both APIs.
        /// </summary>
        public void Specialise()
        {
            var allApis = Commands.SelectMany
            (
                x => (x.Api?.Split(',') ?? Enumerable.Empty<string>())
                    .Concat(x.Parameters.SelectMany(y => y.Api?.Split(',') ?? Enumerable.Empty<string>()))
            )
            .Concat
            (
                Structures.SelectMany
                (
                    x => (x.Api?.Split(',') ?? Enumerable.Empty<string>())
                        .Concat(x.Members.SelectMany(y => y.Api?.Split(',') ?? Enumerable.Empty<string>()))
                )
            )
            .Concat
            (
                Unions.SelectMany
                (
                    x => (x.Api?.Split(',') ?? Enumerable.Empty<string>())
                        .Concat(x.Members.SelectMany(y => y.Api?.Split(',') ?? Enumerable.Empty<string>()))
                )
            )
            .Concat
            (
                Enums.SelectMany
                (
                    x => (x.Api?.Split(',') ?? Enumerable.Empty<string>())
                        .Concat(x.Values.SelectMany(y => y.Api?.Split(',') ?? Enumerable.Empty<string>()))
                )
            )
            .Concat(Features.SelectMany(x => x.Api.Split(',')))
            .Concat(Extensions.SelectMany(x => x.Supported))
            .Distinct()
            .ToArray();
            Commands = Commands.SelectMany
            (
                x => x.Api is null && x.Parameters.Any(y => y.Api is not null)
                    ? allApis.Select
                      (
                          y => new CommandDefinition
                          (
                              x.Name, x.ReturnType,
                              x.Parameters.Where
                              (
                                  z => z.Api is null || z.Api == y || y is not null && z.Api.Split(',').Contains(y)
                              ).ToArray(),
                              x.SuccessCodes, x.ErrorCodes, y
                          )
                      )
                    : Enumerable.Repeat(x, 1)
            ).ToArray();
            Structures = Structures.SelectMany
            (
                x => x.Api is null && x.Members.Any(y => y.Api is not null)
                    ? allApis.Select
                      (
                          y => new StructureDefinition
                          (
                              x.Name, x.Alias,
                              x.Members.Where
                              (
                                  z => z.Api is null || z.Api == y || y is not null && z.Api.Split(',').Contains(y)
                              ).ToArray(),
                              string.Join(',', x.Extends), y
                          )
                      )
                    : Enumerable.Repeat(x, 1)
            ).ToArray();
            Unions = Unions.SelectMany
            (
                x => x.Api is null && x.Members.Any(y => y.Api is not null)
                    ? allApis.Select
                      (
                          y => new StructureDefinition
                          (
                              x.Name, x.Alias,
                              x.Members.Where
                              (
                                  z => z.Api is null || z.Api == y || y is not null && z.Api.Split(',').Contains(y)
                              ).ToArray(),
                              string.Join(',', x.Extends), y
                          )
                      )
                    : Enumerable.Repeat(x, 1)
            ).ToArray();
            Enums = Enums.SelectMany
            (
                x => x.Api is null && x.Values.Any(y => y.Api is not null)
                    ? allApis.Select
                      (
                          y => new EnumDefinition
                          (
                              x.Name, x.Type,
                              x.Values.Where
                              (
                                  z => z.Api is null || z.Api == y || y is not null && z.Api.Split(',').Contains(y)
                              ).ToArray(),
                              x.BitWidth, y
                          )
                      )
                    : Enumerable.Repeat(x, 1)
            ).ToArray();
        }
    }
}
